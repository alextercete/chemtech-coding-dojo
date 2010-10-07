__all__ = ['calcula_total']

def calcula_total(lista):
    lista.sort(reverse=True)
    nova_lista = []
    for indice, valor in enumerate(lista):
        nova_lista.append(valor / 2. if indice % 2 != 0 else valor)

    return sum(nova_lista)