package miojo;

public class FabricaDeMiojo {

	public Object calculaTempo(int tempoPrimeiraAmpulheta,
			                   int tempoSegundaAmpulheta) {
		
		// Foi o Mariano!
		//return Math.abs(tempoPrimeiraAmpulheta-tempoSegundaAmpulheta) + Math.max(tempoPrimeiraAmpulheta, tempoSegundaAmpulheta);
		
		
		if (umDosNumerosEh3(tempoPrimeiraAmpulheta, tempoSegundaAmpulheta)) {
			return 3;
		}
		
		if (ehDiferencaDe3(tempoPrimeiraAmpulheta, tempoSegundaAmpulheta))
		{
			return Math.max(tempoPrimeiraAmpulheta, tempoSegundaAmpulheta);
		}
		
		return 3;
	}
	
	private boolean ehDiferencaDe3 (int tempo1, int tempo2)
	{
		return Math.abs(tempo2 - tempo1) == 3;			
	}

	private boolean umDosNumerosEh3 (int numero1, int numero2)
	{
		return (numero1 == 3 || numero2 == 3);
	}
	
}
