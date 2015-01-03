''' <summary>
''' Contains various math-like functions.
''' </summary>
Public Module mathematics
	Public Function CustomerBuying As String
			'Make new Customer and get his/her data for log
			Dim integerStoreLevel, integerStoreShelf, integerStoreBin, integerBinQuantity, integerBinPrice As Integer
			Dim stringBinName, stringReturn As String
			Dim randomGenerator As New Random()
			Dim CustomerNew(5) As String
			'CustomerNew(0) = gamecache.playerCharacter.CurrentCountry
			'HACK: Delete next line when locationCounrty is fixed & UnComment above.
			CustomerNew(0) = "English"
			gamecache.cacheCustomer.GetCurrentCustomer = CustomerNew
			CustomerNew = gamecache.cacheCustomer.GetCurrentCustomer 'Ethnic, Name, Gender, Age, Money, Desire
			'Setting Random's for slot choosing.
			stringReturn = "0"
			integerStoreLevel = randomGenerator.Next(store.arrayLevel.GetUpperBound(0))
			integerStoreShelf = randomGenerator.Next(store.arrayLevel(integerStoreLevel).arrayShelf.GetUpperBound(0))
			integerStoreBin = randomGenerator.Next((store.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin.GetUpperBound(0)) + 1)
			'Getting Bin data to local variable's.
			stringBinName = gamecache.currentCharacterStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).ArticleName
			integerBinQuantity = gamecache.currentCharacterStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
			integerBinPrice = gamecache.currentCharacterStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).ArticleLastSell
			'First check for quantity in Bin
			If integerBinQuantity > 0 Then 'STASH
				'Check for enough CustomerMoney
				If integerBinPrice <= CType(CustomerNew(4), Integer) Then 'BUY
					If ((CType(CustomerNew(4), Integer) / 100) * CType(CustomerNew(5), Integer)) >= integerBinPrice Then 'INTRESTED
						'set Return for formStatus.textboxLog
						stringReturn = stringBinName & " sold to " & CustomerNew(1) & " ($ " & CustomerNew(4) & ") from slot " & integerStoreBin & Chr(10)
						'Add Article Sell price to Balance
						gamecache.currentCharacterStatistics.Balance += integerBinPrice
						'Remove 1 item from selected Bin and Saves.
						gamecache.currentCharacterStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity -= 1
						gamecache.currentCharacterStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(gamecache.currentCharacterStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
						'Add data to Statistics.
						gamecache.currentCharacterStatistics.TotalItemsSold += 1
						gamecache.currentCharacterStatistics.TotalEarnings += integerBinPrice
					Else 'NOTINTRESTRED
						stringReturn = stringBinName & " didn't sell to " & CustomerNew(1) & ", because of no desire from slot " & integerStoreBin & Chr(10)
					End If
					
				ElseIf integerBinPrice >= CType(CustomerNew(4), Integer) Then 'TOOEXPENSIVE
					'Set Return for formStatus.textboxLog
					stringReturn = stringBinName & " too Expensive for " & CustomerNew(1) & " ($ " & CustomerNew(4) & ") from slot " & integerStoreBin & Chr(10)
				End If
				
			ElseIf integerBinQuantity = 0 Then 'NOSTASH
				'Set Return for formStatus.textboxLog
				stringReturn = stringBinName & " stock Depleted on slot " & integerStoreBin & Chr(10)
			End If
			'Return end result.
			Return stringReturn
	End Function
End Module
