package miojo;

import static org.junit.Assert.assertEquals;

import org.junit.Test;

public class TestMiojo {

	@Test
	public void duasAmpulhetasDe3Minutos_demora3Minutos() {
		
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(3, fabricaDeMiojo.calculaTempo(3, 3));
		
	}
	
	@Test
	public void duasAmpulhetasDeDiferencasDe3Minutos_PrimeiraMaior_demoraAPrimeira(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(5, fabricaDeMiojo.calculaTempo(5, 2));
	}
	
	@Test
	public void duasAmpulhetasDeDiferencasDe3Minutos_SegundaMaior_demoraASegunda(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(5, fabricaDeMiojo.calculaTempo(2, 5));
	}
	
	@Test
	public void duasAmpulhetasDe3MinEOutraDe6Min_Retorna3(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(3, fabricaDeMiojo.calculaTempo(3, 6));
	}

	@Test
	public void duasAmpulhetasComUmaIgualA3_Retorna3(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(3, fabricaDeMiojo.calculaTempo(1, 3));
	}
	
	@Test
	public void duasAmpulhetasDe1_retorna3(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(3, fabricaDeMiojo.calculaTempo(1, 1));
	}

	@Test
	public void umaAmpulhetaDe1OutraDe2_retorna3(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(3, fabricaDeMiojo.calculaTempo(2, 1));
	}
	
	@Test
	public void umaAmpulhetaDe5OutraDe7_retorna10(){
		FabricaDeMiojo fabricaDeMiojo = new FabricaDeMiojo();
		
		assertEquals(10, fabricaDeMiojo.calculaTempo(5, 7));
	}
	
}
