import unittest
from campo_minado import processa_campo, ParametroInvalidoError 

class TesteCampoMinado(unittest.TestCase):
    def teste_1x1_sem_bombas(self):
        campo = [[None]]
        self.assertEquals(processa_campo(campo), [[0]])
    
    def teste_1x1_com_bombas(self):
        campo = [['*']]
        self.assertEquals(processa_campo(campo), [['*']])
    
    def teste_1x2_com_1_bomba_na_esquerda(self):
        campo = [['*', None]]
        self.assertEquals(processa_campo(campo), [['*', 1]])
    
    def teste_1x2_com_1_bomba_na_direita(self):
        campo = [[None, '*']]
        self.assertEquals(processa_campo(campo), [[1, '*']])
    
    def teste_1x2_com_0_bomba(self):
        campo = [[None, None]]
        self.assertEquals(processa_campo(campo), [[0, 0]])
    
    def teste_1x2_com_2_bombas(self):
        campo = [['*', '*']]
        self.assertEquals(processa_campo(campo), [['*', '*']])
    
    def teste_2x2_com_0_bomba(self):
        campo = [[None, None],
                 [None, None]]
        
        self.assertEquals(processa_campo(campo), [[0, 0],
                                                  [0, 0]])
            
    def teste_2x2_com_4_bombas(self):
        campo = [['*', '*'],
                 ['*', '*']]
        
        self.assertEquals(processa_campo(campo), campo)
            
    def teste_2x2_com_1_bombas_no_0_0(self):
        campo = [['*' , None],
                 [None, None]]
        
        self.assertEquals(processa_campo(campo), [['*', 1],
                                                  [1  , 1]])
        
    def teste_2x2_com_1_bombas_no_1_1(self):
        campo = [[None, None],
                 [None, '*' ]]
        
        self.assertEquals(processa_campo(campo), [[1, 1  ],
                                                  [1, '*']])
        
    def teste_3x3_com_0_bombas(self):
        campo = [[None, None, None],
                 [None, None, None],
                 [None, None, None]]
        
        self.assertEquals(processa_campo(campo), [[0, 0, 0],
                                                  [0, 0, 0],
                                                  [0, 0, 0]])

    def teste_3x3_com_todas_bombas(self):
        campo = [['*', '*', '*'],
                 ['*', '*', '*'],
                 ['*', '*', '*']]
        
        self.assertEquals(processa_campo(campo), [['*', '*', '*'],
                                                  ['*', '*', '*'],
                                                  ['*', '*', '*']])
        
    def teste_3x3_com_todas_bombas(self):
        campo = [['*' , None, None],
                 [None, None, None],
                 [None, None, None]]
        
        self.assertEquals(processa_campo(campo), [['*', 1, 0],
                                                  [1  , 1, 0],
                                                  [0  , 0, 0]])

    # Analisar outro dia como verificar tipos em Python
    def xteste_recebe_parametro_invalido(self):
        campo = 54524
        self.assertRaises(ParametroInvalidoError,
                          processa_campo,
                          campo);

unittest.main()
