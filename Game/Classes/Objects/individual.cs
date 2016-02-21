using System;

/// <summary>
/// Creates a individual with Ethnic, Gender, Name, Age, Money & Desire.
/// First load Ethnic into it sand then use through ReturnRandom()
/// </summary>
public class individual
{
    public string SettingRequest;
    private iniHandler iniFilehandler = new iniHandler();
	private Random randomGenerator = new Random();

	private string[,] stringDetails;
	private string[] stringNamelistM;
	private string[] stringNamelistF;
	private string stringEthnic;
	private string[] stringRandom = new string[5];
	/// <summary>
	/// Creates an empty Customer Class.
	/// </summary>
	public individual()
	{

	}
	/// <summary>
	/// Loads all the data of the specified Ethnic.
	/// </summary>
	/// <param name="pathEthnic">Full path of chosen Ethnic.</param>
	public void Load(string pathEthnic)
	{
		//Set current Ethnic Variable to memory
		string[] stringConversion = pathEthnic.Split(Char(92));
		stringEthnic = stringConversion(stringConversion.GetUpperBound(0));
		//Fill stringDetails with pathEthnic
		stringDetails = iniFilehandler.Load(pathEthnic + "\\details.ini");
		//Fill stringNamelistM with pathEthnic
		stringNamelistM = LoadNamelist(pathEthnic + "\\NamelistM.nld");
		//Fill stringNamelistF with pathEthnic
		stringNamelistF = LoadNamelist(pathEthnic + "\\NamelistF.nld");
	}
	/// <summary>
	/// Loads a namelist according to set Ethnic and Gender.
	/// </summary>
	/// <param name="pathNamelist">complete path with file.</param>
	/// <returns>String() with single name per dimension.</returns>
	private string[] LoadNamelist(string pathNamelist)
	{
		string[] stringMediator = null;
		string stringStream = "";
		using (System.IO.StreamReader streamReader = new System.IO.StreamReader(pathNamelist)) {
			stringStream = streamReader.ReadToEnd();
		}

		stringMediator = stringStream.Split(Char(10));
		int integerMediator = 0;
		foreach (string line in stringMediator) {
		    if (string.IsNullOrEmpty(stringMediator[integerMediator])) {
				integerMediator += 1;
				continue;
			}
		    stringMediator[integerMediator] = line.Remove(line.Length - 1, 1);
			integerMediator += 1;
		}
		return stringMediator;
	}
	/// <summary>
	/// Gets or Sets an Individual, empty variable's will be random according to [Ethnic]\details.ini.
	/// (Name, Gender, Age, Money, Desire) as String(4)
	/// </summary>
	public string[] ToStrings {
		get {
	        if (string.IsNullOrEmpty(stringRandom[1]))
				if (randomGenerator.Next(2010) <= 1000)
					stringRandom[1] = "F";
				else
					stringRandom[1] = "M";
			//Gender based on WikiPedia (101M on 100F)
			if (string.IsNullOrEmpty(stringRandom[2]))
				stringRandom[2] = Convert.ToString(randomGenerator.Next(Convert.ToInt32(ReturnValue["AgeMinimum"]), Convert.ToInt32(ReturnValue["AgeMaximum"])));
			//Age
			if (string.IsNullOrEmpty(stringRandom[3]))
				stringRandom[3] = Convert.ToString(randomGenerator.Next(Convert.ToInt32(ReturnValue["MoneyMinimum"]), Convert.ToInt32(ReturnValue["MoneyMaximum"])));
			//Money
			if (string.IsNullOrEmpty(stringRandom[4]))
				stringRandom[4] = Convert.ToString(randomGenerator.Next(Convert.ToInt32(ReturnValue["DesireMinimum"]), Convert.ToInt32(ReturnValue["DesireMaximum"])));
			//Desire
			if (string.IsNullOrEmpty(stringRandom[0]))
				if (stringRandom[1] == "M")
			        stringRandom[0] = stringNamelistM[randomGenerator.Next(stringNamelistM.GetUpperBound(0))];
				else
			        stringRandom[0] = stringNamelistF[randomGenerator.Next(stringNamelistF.GetUpperBound(0))];
			//Name

			return stringRandom;
		}
//Set all info from Value()
		set { stringRandom = value; }
	}
	/// <summary>
	/// Searches in stringDetails for requested Setting and set/returns that value.
	/// </summary>
	/// <returns></returns>
	public string ReturnValue {
		get {
			int integerColumn = 0;
			int integerRow = 0;
			do {
				do {
			        if (stringDetails[integerColumn, integerRow].Contains(SettingRequest)) {
			            return stringDetails[integerColumn, integerRow + 1];
					}
					integerRow += 1;
				} while (!(integerRow > stringDetails.GetUpperBound(1)));
				integerColumn += 1;
			} while (!(integerColumn > stringDetails.GetUpperBound(0)));
			return "";
		}
	}

	public string Ethnic {
		get { return stringEthnic; }
	}
}