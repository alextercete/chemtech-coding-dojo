NAO_ESCUTOU = "O QUE? FALA MAIS ALTO!"
ESCUTOU_MAS_NAO_ENTENDEU = "NÃO, NÃO DESDE 1938"

class VelhaSurda
    attr_accessor :foi_embora
    
    def initialize
        @foi_embora = false
    end
    
    def ouvir(mensagem)
        mensagem_gritando = mensagem.upcase
        if (mensagem == "TCHAU")
            @foi_embora = true
            return "TCHAU"
        elsif (mensagem_gritando == mensagem)
            return ESCUTOU_MAS_NAO_ENTENDEU
        end
        return NAO_ESCUTOU
    end
end

class Interlocutor
    def fala_com(quem, mensagem)
        return quem.ouvir(mensagem)
    end    
end