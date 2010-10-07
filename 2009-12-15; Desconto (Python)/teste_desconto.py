import unittest
from desconto import *

class TesteDesconto(unittest.TestCase):

    def teste_apenas_um_item(self):
        lista_de_itens = [2]
        self.assertEqual(calcula_total(lista_de_itens), 2)

    def teste_lista_com_dois_itens_diferentes(self):
        lista_de_itens = [1, 2]
        self.assertEqual(calcula_total(lista_de_itens), 2.5)
    
    def teste_lista_com_dois_itens_iguais(self):
        lista_de_itens = [3, 3]
        self.assertEqual(calcula_total(lista_de_itens), 4.5)

    def teste_lista_com_tres_itens_diferentes(self):
        lista_de_itens = [3, 3, 2]
        self.assertEqual(calcula_total(lista_de_itens), 6.5)

    def teste_lista_com_cinco_itens_diferentes_em_ordem(self):
        lista_de_itens = [10, 20, 30, 40, 50]
        self.assertEqual(calcula_total(lista_de_itens), 120)
                
    def teste_lista_com_cinco_itens_diferentes_fora_de_ordem(self):
        lista_de_itens = [50, 20, 10, 30, 40]
        self.assertEqual(calcula_total(lista_de_itens), 120)

unittest.main()