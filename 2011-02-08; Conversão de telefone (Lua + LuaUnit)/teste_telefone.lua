require('luaunit')
require('telefone')

TesteTelefone = {}
	function TesteTelefone:testeEntraUmSaiUm()
		assertEquals( converteTelefone("1"), "1" )
	end
	
	function TesteTelefone:testeEntraZeroSaiZero()
		assertEquals( converteTelefone("0"), "0" )
	end
	
	function TesteTelefone:testeEntraHifenSaiHifen()
		assertEquals( converteTelefone("-"), "-" )
	end
	
	function TesteTelefone:testeEntraUmZeroHifenSaiUmZeroHifen()
		assertEquals( converteTelefone("10-"), "10-" )
	end
	
	function TesteTelefone:testeEntraASaiDois()
		assertEquals( converteTelefone("A"), "2" )
	end
	
	function TesteTelefone:testeEntraABCSai3Dois()
		assertEquals( converteTelefone("ABC"), "222" )
	end
	
	function TesteTelefone:testeEntrarQualquerSequenciaABCSaiTudo2()
		assertEquals( converteTelefone("ABCBBCA"), "2222222" )
	end
	
	function TesteTelefone:testeEntrarQualquerSequenciaComABCeDEFSaiTudo2ou3()
		assertEquals( converteTelefone("ABCBBCADEFDEF"), "2222222333333" )
	end

	function TesteTelefone:testeEntrarQualquerSequenciaComABCDEFGHIJKLSai2ou3ou4ou5()
		assertEquals( converteTelefone("ABCDEFGHIJKL"), "222333444555" )
	end

	function TesteTelefone:testeEntrarLETRASaiNUMERO()
		assertEquals( converteTelefone("1-HOME-SWEET-HOME"), "1-4663-79338-4663" )
	end
	
LuaUnit:run()