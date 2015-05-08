
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
	
	//오브젝트카운트 멤버함수
	public static int chkEnemyCnt()
	{
		return cntEnemy;
	}
	
	public static int chkCloudCnt()
	{
		return cntCloud;
	}
	
	public static int chkBuildingCnt()
	{
		return cntBuilding;
	}
	
	public static void plusEnemyCnt()
	{
		cntEnemy++;
	}
	
	public static void minusEnemyCnt()
	{
		cntEnemy--;
	}
	
	public static void plusCloudCnt()
	{
		cntCloud++;
	}
	
	public static void minusCloudCnt()
	{
		cntCloud--;
	}
	
	public static void plusBuildingCnt()
	{
		cntBuilding++;
	}
	
	public static void minusBuildingCnt()
	{
		cntBuilding--;
	}
	//오브젝트카운트 멤버함수

}
