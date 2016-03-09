using System;
/// <summary>
/// Contains various math-like functions.
/// </summary>
public class mathematics
{
    level levelStore;
    shelf shelfStore;
    bin binStore;
    
    public string CustomerBuying()
    {
        //Make new Customer and get his/her data for log
        int integerBinQuantity = 0;
        int integerBinPrice = 0;
        int integerBinSlot = 0;
        int integerShelfSlot = 0;
        int integerLevelSlot = 0;
        string stringBinName = null;
        string stringReturn = null;
        Random randomGenerator = new Random();
        
        //CustomerNew[0] = gamecache.playerCharacter.CurrentCountry
        //Setting Random's for slot choosing.
        
        individual curCustomer = gamecache.cacheCustomer.individualDatabase[0];
        curCustomer.Randomize();
            stringReturn = "0";
        integerLevelSlot = randomGenerator.Next(gamecache.currentCharacterStore.arrayLevel.GetUpperBound(0));
        levelStore = gamecache.currentCharacterStore.arrayLevel[integerLevelSlot];
        integerShelfSlot = randomGenerator.Next(levelStore.arrayShelf.GetUpperBound(0));
        shelfStore = levelStore.arrayShelf[integerShelfSlot];
        integerBinSlot = randomGenerator.Next((shelfStore.arrayBin.GetUpperBound(0)) + 1);
        binStore = shelfStore.arrayBin[integerBinSlot];
        //Getting Bin data to local variable's.
        stringBinName = binStore.ArticleName;
        integerBinQuantity = binStore.BinQuantity;
        integerBinPrice = binStore.ArticleLastSell;
        //First check for quantity in Bin
        //STASH
        if (integerBinQuantity > 0) {
            //Check for enough CustomerMoney
            //BUY
            if (integerBinPrice <= curCustomer.MoneyRandom) {
                //INTRESTED
                if (((Convert.ToInt32(curCustomer.MoneyMinimum) / 100) * Convert.ToInt32(curCustomer.MoneyMaximum)) >= integerBinPrice) {
                    //set Return for formStatus.textboxLog
                    stringReturn = stringBinName + " sold to " + curCustomer.Name + " ($ " + curCustomer.MoneyRandom + ") from slot " + integerBinSlot + (char)10;
                    //Add Article Sell price to Balance
                    gamecache.currentCharacter.Balance += integerBinPrice;
                    //Remove 1 item from selected Bin and Saves.
                    gamecache.currentCharacterStore.arrayLevel[integerLevelSlot].arrayShelf[integerShelfSlot].arrayBin[integerBinSlot].BinQuantity -= 1;
                    gamecache.currentCharacterStore.arrayLevel[integerLevelSlot].arrayShelf[integerShelfSlot].arrayBin[integerBinSlot].BinSave(gamecache.currentCharacterStore.arrayLevel[integerLevelSlot].arrayShelf[integerShelfSlot].ShelfPath);
                    //Add data to Statistics.
                    gamecache.currentCharacter.ItemsSoldTotal += 1;
                    gamecache.currentCharacter.EarningsTotal += integerBinPrice;
                    //NOTINTRESTRED
                } else {
                    stringReturn = stringBinName + " didn't sell to " + curCustomer.Name + ", because of no desire from slot " + integerBinSlot + (char)10;
                }

                //TOOEXPENSIVE
            } else if (integerBinPrice >= Convert.ToInt32(curCustomer.MoneyRandom)) {
                //Set Return for formStatus.textboxLog
                stringReturn = stringBinName + " too Expensive for " + curCustomer.Name + " ($ " + curCustomer.MoneyRandom + ") from slot " + integerBinSlot + (char)10;
            }

            //NOSTASH
        } else if (integerBinQuantity == 0) {
            //Set Return for formStatus.textboxLog
            stringReturn = stringBinName + " stock Depleted on slot " + integerBinSlot + (char)10;
        }
        //Return end result.
        return stringReturn;
    }
}