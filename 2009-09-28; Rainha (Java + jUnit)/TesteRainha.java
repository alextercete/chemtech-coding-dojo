package rainha;

import junit.framework.TestCase;

public class TesteRainha extends TestCase {  
	
	private MovimentadorRainha movimentador;
	
	public void testeNaoSaiDoLugar() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(0, movimentador.movePara(0, 0));
	}  
	public void testeMoveCasaVizinha() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(1, movimentador.movePara(0, 1));		
	}
	
	public void testeMoveNaLinha() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(1, movimentador.movePara(8, 0));
	}
		
	public void testeMoveNaColuna() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(1, movimentador.movePara(0, 8));		
	}
	
	public void testeMoveEmL() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(2, movimentador.movePara(2, 3));		
	}
	
	public void testeMoveEmOutroL() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(2, movimentador.movePara(3, 5));		
	}
	
	public void testeMoveDiagonal() throws Exception {  
		movimentador = new MovimentadorRainha(0, 0);
		assertEquals(1, movimentador.movePara(2, 2));		
	}
}
