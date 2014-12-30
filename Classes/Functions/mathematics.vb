''' <summary>
''' Contains various math-like functions.
''' </summary>
Public Module mathematics
	Public Function CustomerBuying As String
			'Make new Customer and get his/her data for log
			Dim integerStoreLevel, integerStoreShelf, integerStoreBin, integerBinQuantity, integerBinPrice As Integer
			Dim stringBinName, stringReturn As String
			Dim randomGenerator As New Random()
			Dim CustomerNew As New customer
			CustomerNew.newCustomer()
			'Setting Random's for slot choosing.
			stringReturn = "0"
			integerStoreLevel = randomGenerator.Next(store.arrayLevel.GetUpperBound(0))
			integerStoreShelf = randomGenerator.Next(store.arrayLevel(integerStoreLevel).arrayShelf.GetUpperBound(0))
			integerStoreBin = randomGenerator.Next((store.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin.GetUpperBound(0)) + 1)
			'Getting Bin data to local variable's.
			stringBinName = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).ArticleName
			integerBinQuantity = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
			integerBinPrice = gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).ArticleLastSell
			'First check for quantity in Bin
			If integerBinQuantity > 0 Then 'STASH
				'Check for enough CustomerMoney
				If integerBinPrice <= CustomerNew.Money Then 'BUY
					If ((CustomerNew.Money / 100) * CustomerNew.Desire) >= integerBinPrice Then 'INTRESTED
						'set Return for formStatus.textboxLog
						stringReturn = stringBinName & " sold to " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & integerStoreBin & Chr(10)
						'Add Article Sell price to Balance
						gamecache.playerCharacter.Balance += integerBinPrice
						'Remove 1 item from selected Bin and Saves.
						gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity -= 1
						gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(gamecache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
						'Add data to Statistics.
						gamecache.playerCharacter.TotalItemsSold += 1
						gamecache.playerCharacter.TotalEarnings += integerBinPrice
					Else 'NOTINTRESTRED
						stringReturn = stringBinName & " didn't sell to " & CustomerNew.Name & ", because of no desire from slot " & integerStoreBin & Chr(10)
					End If
					
				ElseIf integerBinPrice >= CustomerNew.Money Then 'TOOEXPENSIVE
					'Set Return for formStatus.textboxLog
					stringReturn = stringBinName & " too Expensive for " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & integerStoreBin & Chr(10)
				End If
				
			ElseIf integerBinQuantity = 0 Then 'NOSTASH
				'Set Return for formStatus.textboxLog
				stringReturn = stringBinName & " stock Depleted on slot " & integerStoreBin & Chr(10)
			End If
			'Return end result.
			Return stringReturn
	End Function
End Module
