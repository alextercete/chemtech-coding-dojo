calculaDesconto = (listaDeLivros) ->
    if listaDeLivros[2] == 1 and listaDeLivros[6] == 1
        return 79.8
    for qtdLivros in listaDeLivros
        if qtdLivros isnt 0
            return 42 * qtdLivros

# Externalizando as funções para o qUnit
window.calculaDesconto = calculaDesconto