
public static class GameStatus{
	static bool dmgTaken = false;
	
	public static void regenStop()
	{
		dmgTaken = true;
	}
	
	public static void regenStart()
	{
		dmgTaken = false;
	}
	
	public static bool chkDmg()
	{
		return dmgTaken;
	}

}
