require 'test/unit'
require 'velha_surda'

class VelhaSurdaTestCase < Test::Unit::TestCase

    def setup
        @interlocutor = Interlocutor.new
        @velha_surda = VelhaSurda.new
    end

    def teste_a_velha_nao_escuta_oi
        assert_equal(NAO_ESCUTOU,
                     @interlocutor.fala_com(@velha_surda, 'Oi!' ))
    end
    
    def teste_a_velha_nao_escuta_outra_coisa
        assert_equal(NAO_ESCUTOU,
                     @interlocutor.fala_com(@velha_surda, 'Outra coisa!' ))
    end
    
    def teste_a_velha_escuta_errado_OI
        assert_equal(ESCUTOU_MAS_NAO_ENTENDEU,
                     @interlocutor.fala_com(@velha_surda, 'OI!' ))
    end
    
    def teste_a_velha_escuta_errado_OUTRA_COISA
        assert_equal(ESCUTOU_MAS_NAO_ENTENDEU,
                     @interlocutor.fala_com(@velha_surda, 'OUTRA COISA!' ))
    end

    def teste_eu_grito_tchau_e_a_velha_vai_embora
        @interlocutor.fala_com(@velha_surda, 'TCHAU')
        assert_equal(true, @velha_surda.foi_embora)
    end
    
    def teste_eu_digo_tchau_e_a_velha_nao_vai_embora
        @interlocutor.fala_com(@velha_surda, 'tchau')
        assert_equal(false, @velha_surda.foi_embora)
    end
    
    def teste_eu_digo_qualquer_coisa_e_a_velha_fica
        @interlocutor.fala_com(@velha_surda, 'qualquer coisa')
        assert_equal(false, @velha_surda.foi_embora)
    end
    
end