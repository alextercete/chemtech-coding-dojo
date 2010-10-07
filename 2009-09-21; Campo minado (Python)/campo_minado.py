class ParametroInvalidoError(Exception):
    pass

def processa_campo(campo):
    saida = campo
    
    for linha in saida:
        for i, celula in enumerate(linha):
            if celula == None:
                linha[i] = sum([l.count('*') for l in saida])
    
    return saida
