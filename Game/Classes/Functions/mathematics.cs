using System;

/// <summary>
/// Contains various math-like functions.
/// </summary>
public static class mathematics
{
	public static string CustomerBuying()
	{
		//Make new Customer and get his/her data for log
		int integerStoreLevel = 0;
		int integerStoreShelf = 0;
		int integerStoreBin = 0;
		int integerBinQuantity = 0;
		int integerBinPrice = 0;
		string stringBinName = null;
		string stringReturn = null;
		Random randomGenerator = new Random();
		string[] CustomerNew = new string[6];
		//CustomerNew[0] = gamecache.playerCharacter.CurrentCountry
		//HACK: Delete next line when locationCounrty is fixed & UnComment above.
		CustomerNew[0] = "English";
		gamecache.cacheCustomer.GetCurrentCustomer = CustomerNew;
		CustomerNew = gamecache.cacheCustomer.GetCurrentCustomer;
		//Ethnic, Name, Gender, Age, Money, Desire
		//Setting Random's for slot choosing.
		stringReturn = "0";
		integerStoreLevel = randomGenerator.Next(store.arrayLevel.GetUpperBound(0));
		integerStoreShelf = randomGenerator.Next(store.arrayLevel[integerStoreLevel].arrayShelf.GetUpperBound(0));
		integerStoreBin = randomGenerator.Next((store.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin.GetUpperBound(0)) + 1);
		//Getting Bin data to local variable's.
		stringBinName = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].ArticleName;
		integerBinQuantity = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity;
		integerBinPrice = gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].ArticleLastSell;
		//First check for quantity in Bin
		//STASH
		if (integerBinQuantity > 0) {
			//Check for enough CustomerMoney
			//BUY
			if (integerBinPrice <= Convert.ToInt32(CustomerNew[4])) {
				//INTRESTED
				if (((Convert.ToInt32(CustomerNew[4]) / 100) * Convert.ToInt32(CustomerNew(5))) >= integerBinPrice) {
					//set Return for formStatus.textboxLog
					stringReturn = stringBinName + " sold to " + CustomerNew[1] + " ($ " + CustomerNew[4] + ") from slot " + integerStoreBin + Char(10);
					//Add Article Sell price to Balance
					gamecache.currentCharacterStatistics.Balance += integerBinPrice;
					//Remove 1 item from selected Bin and Saves.
					gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinQuantity -= 1;
					gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].arrayBin[integerStoreBin].BinSave(gamecache.currentCharacterStore.arrayLevel[integerStoreLevel].arrayShelf[integerStoreShelf].ShelfPath);
					//Add data to Statistics.
					gamecache.currentCharacterStatistics.TotalItemsSold += 1;
					gamecache.currentCharacterStatistics.TotalEarnings += integerBinPrice;
				//NOTINTRESTRED
				} else {
					stringReturn = stringBinName + " didn't sell to " + CustomerNew[1] + ", because of no desire from slot " + integerStoreBin + Char(10);
				}

			//TOOEXPENSIVE
			} else if (integerBinPrice >= Convert.ToInt32(CustomerNew[4])) {
				//Set Return for formStatus.textboxLog
				stringReturn = stringBinName + " too Expensive for " + CustomerNew[1] + " ($ " + CustomerNew[4] + ") from slot " + integerStoreBin + Char(10);
			}

		//NOSTASH
		} else if (integerBinQuantity == 0) {
			//Set Return for formStatus.textboxLog
			stringReturn = stringBinName + " stock Depleted on slot " + integerStoreBin + Char(10);
		}
		//Return end result.
		return stringReturn;
	}
}