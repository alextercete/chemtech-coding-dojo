<?php

const LIGADA = 1;
const DESLIGADA = 0;

function calculaEstadoDasLampadas($numeroLampadas) {

	$retorno = array();

	for ($i = 0; $i < $numeroLampadas; $i++)
	{
		$retorno[] = DESLIGADA;
	}
	
	for ($i = 1; $i <= $numeroLampadas; $i++)
	{
		for ($j = 1; $j <= $numeroLampadas; $j++)
		{
			if ($j % $i == 0)
			{
				$retorno[$j - 1] = $retorno[$j - 1] == DESLIGADA
				                       ? LIGADA
								       : DESLIGADA;
			}
		}
	}
	
	return $retorno;
}

?>