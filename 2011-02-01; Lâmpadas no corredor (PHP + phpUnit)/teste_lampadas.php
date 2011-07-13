<?php

require_once('lampadas.php');

class TesteLampadas extends PHPUnit_Framework_TestCase {

	public function testeUmaLampada() {

		$this->assertEquals(array(LIGADA), calculaEstadoDasLampadas(1));

	}
	
	public function testeDuasLampadas() {

		$this->assertEquals(array(LIGADA, DESLIGADA),
						    calculaEstadoDasLampadas(2));

	}
	
	public function testeTresLampadas() {

		$this->assertEquals(array(LIGADA, DESLIGADA, DESLIGADA),
						    calculaEstadoDasLampadas(3));

	}
	public function testeQuatroLampadas() {

		$this->assertEquals(array(LIGADA, DESLIGADA, DESLIGADA, LIGADA),
						    calculaEstadoDasLampadas(4));

	}

	public function testeCincoLampadas() {

		$this->assertEquals(array(LIGADA, DESLIGADA, DESLIGADA, LIGADA, DESLIGADA),
		                    calculaEstadoDasLampadas(5));

	}
}

?>
