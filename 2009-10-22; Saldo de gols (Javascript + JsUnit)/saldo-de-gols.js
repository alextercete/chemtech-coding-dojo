var ProcessadorJogos = function() {
    this.processaResultado = function(times) {
        var time = times[0];
        if (this.processaSaldo(time) > 0)
            return 1;
        else
            return 0;
    }
    
    this.processaSaldo = function(jogos) {
        var saldo_gols = 0;
        for (var jogo in jogos)
        {
            saldo_gols += jogos[jogo][0] - jogos[jogo][1];
        }
        return saldo_gols;
    }
}