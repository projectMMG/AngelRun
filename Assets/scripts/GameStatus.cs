
public static class GameStatus{
	static bool dmgTaken = false;
	static bool resetTrig = false;
	static bool gameOver = true;
	static bool gameStart = true;
	
	static int cntCloud = 0;
	static int cntEnemy = 0;
	static int cntBuilding = 0;
	
	static int preScore = 0;
	
	//게임오버/스타트 멤버함수
	public static bool chkGameOver()
	{
		return gameOver;
	}
	
	public static void onGameOver()
	{
		gameOver = true;
	}
	
	public static void offGameOver()
	{
		gameOver = false;
	}
	
	public static bool chkGameStart()
	{
		return gameStart;
	}
	
	public static void onGameStart()
	{
		gameStart = true;
	}
	
	public static void offGameStart()
	{
		gameStart = false;
	}
	//게임오버/스타트 멤버함수
	
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
	public static int cntAllObstacle()
	{
		return (cntCloud + cntEnemy + cntBuilding);
	}
	
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
	
	//스코어 멤버함수
	public static int chkPreScore()
	{
		return preScore;
	}
	
	public static void bufInPreScore(int tempScore)
	{
		preScore = tempScore;
	}

}
