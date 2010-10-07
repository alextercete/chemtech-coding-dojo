package rainha;

public class MovimentadorRainha {
	
	private static final int MOV_PARADO = 0;
	private static final int MOV_UM = 1;
	private static final int MOV_DOIS = 2;
	private static final int MOV_INVALIDO = -1;
	
	private int x;
	private int y;
	
	public MovimentadorRainha(int x, int y){
		this.x = x;
		this.y = y;
	}
	
	public int movePara(int x, int y) {
		int numeroMovimentos = MOV_INVALIDO;
		
		int deltaX = this.x  - x;
		int deltaY = this.y  - y;
		if (deltaX == 0 && deltaY == 0) {
			numeroMovimentos = MOV_PARADO;
		}
		else if ((deltaX == 0 || deltaY == 0)
					|| (deltaX == deltaY)) {
			numeroMovimentos = MOV_UM;
		}		
		else{
			numeroMovimentos = MOV_DOIS;
		}
	
		return numeroMovimentos;		
	}
}
