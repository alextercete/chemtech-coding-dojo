function testUmTimeComUmJogoGanho() {
    var processador_jogos = new ProcessadorJogos(),
        time = [[15, 0]],
        times = [time];
    
    assertEquals("Um time e um jogo ganho", 
                 1,
                 processador_jogos.processaResultado(times));
}

function testUmTimeComUmJogoPerdido() {
    var processador_jogos = new ProcessadorJogos(),
        time = [[0, 1]],
        times = [time];
    
    assertEquals("Um time e um jogo perdido", 
                 0,
                processador_jogos.processaResultado(times));
}

function testUmTimeComDoisJogosGanhos() {
    var processador_jogos = new ProcessadorJogos(),
        time = [[1, 0], [9, 0]],
        times = [time];
    
    assertEquals("Um time e dois jogos ganhos", 
                 1,
                 processador_jogos.processaResultado(times));
}

function testUmTimeComDoisJogosEUmJogoGanhoApenas() {
    var processador_jogos = new ProcessadorJogos(),
        time = [[0, 1], [2, 0]],
        times = [time];
    
    assertEquals("Um time perde o primeiro e ganha o segundo", 
                 1,
                 processador_jogos.processaResultado(times));
}

function testGanhaOPrimeiroPerdeOSegundoDeMaisQueOGanho() {
    var processador_jogos = new ProcessadorJogos(),
        time = [[1, 0], [0, 9]],
        times = [time];
    
    assertEquals("Um time perde o segundo de muito mais que ganhou o primeiro", 
                 0,
                 processador_jogos.processaResultado(times));
}