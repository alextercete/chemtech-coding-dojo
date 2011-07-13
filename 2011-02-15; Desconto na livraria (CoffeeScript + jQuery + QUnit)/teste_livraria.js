$(document).ready(function(){

    test("Quando só tem um HP1", function() {
        var listaDeLivros = [1, 0, 0, 0, 0, 0, 0];
        equals( calculaDesconto(listaDeLivros),
                42, 
                "Não deve receber desconto" );
    });

    test("Quando tem dois livros do mesmo", function() {
        var listaDeLivros = [2, 0, 0, 0, 0, 0, 0];
        equals( calculaDesconto(listaDeLivros),
                84, 
                "Não deve receber desconto" );
    });
    
    test("Quando só tem um HP2", function() {
        var listaDeLivros = [0, 1, 0, 0, 0, 0, 0];
        equals( calculaDesconto(listaDeLivros),
                42, 
                "Não deve receber desconto" );
    });
    
    test("Quando só tem um HP7", function() {
        var listaDeLivros = [0, 0, 0, 0, 0, 0, 1];
        equals( calculaDesconto(listaDeLivros),
                42, 
                "Não deve receber desconto" );
    });
    
    test("Quando tem um HP3 e um HP7", function() {
        var listaDeLivros = [0, 0, 1, 0, 0, 0, 1];
        equals( calculaDesconto(listaDeLivros),
                79.8, 
                "Deve receber desconto" );
    });
    
});
