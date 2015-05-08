
public static class GameStatus{
	static bool dmgTaken = false;
	static bool resetTrig = false;
	
	static int cntCloud = 0;
	static int cntEnemy = 0;
	static int cntBuilding = 0;
	
	//리젠 멤버함수
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
	//리젠 멤버함수
	
	
	//게임재시작 멤버함수
	public static bool chkResetTrig()
	{
		return resetTrig;
	}
	
	public static bool chkRdy2Restart()
	{
		int sumObjCnt = cntCloud + cntEnemy + cntBuilding;
		
		if(sumObjCnt == 0)
		{
			return true;
		}
		else
		{
			return false;
		}
		
	}
	//게임재시작 멤버함수

}
