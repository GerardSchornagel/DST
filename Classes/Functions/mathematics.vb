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
			
			stringReturn = "0"
			integerStoreLevel = randomGenerator.Next(store.arrayLevel.GetUpperBound(0))
			integerStoreShelf = randomGenerator.Next(store.arrayLevel(integerStoreLevel).arrayShelf.GetUpperBound(0))
			Dim temp As Integer = (store.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin.GetUpperBound(0))			
			integerStoreBin = randomGenerator.Next(temp + 1)
			stringBinName = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).ArticleName
			integerBinQuantity = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity
			integerBinPrice = cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).ArticleLastSell
			
			If integerBinQuantity > 0 Then 'Check for available quantity.
				If integerBinPrice <= CustomerNew.Money Then 'BUY:Check for customer-money and item sell-price
					stringReturn = stringBinName & " sold to " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & integerStoreBin & Chr(10)
					cache.playerCharacter.Balance += integerBinPrice
					cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinQuantity -= 1
					cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).arrayBin(integerStoreBin).BinSave(cache.playerStore.arrayLevel(integerStoreLevel).arrayShelf(integerStoreShelf).ShelfPath)
					cache.playerCharacter.TotalItemsSold += 1
'					
				ElseIf integerBinPrice >= CustomerNew.Money Then 'NOCASH:Check for customer-money and item sell-price
					stringReturn = stringBinName & " too Expensive for " & CustomerNew.Name & " ($ " & CustomerNew.Money & ") from slot " & integerStoreBin & Chr(10)
				End If
				
			ElseIf integerBinQuantity = 0 Then 'NOSTASH:Check for customer-money and item sell-price
				stringReturn = stringBinName & " stock Depleted on slot " & integerStoreBin & Chr(10)
			End If
			Return stringReturn
	End Function
End Module
