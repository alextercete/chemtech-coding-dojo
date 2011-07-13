function converteTelefone(entrada)
	saida = ""
	letra = ""

	for c in entrada:gmatch"." do
		letra = c
		if c == "A" or c == "B" or c == "C" then
			letra = "2"
		elseif c == "D" or c == "E" or c == "F" then
			letra = "3"
		elseif c == "G" or c == "H" or c == "I" then
			letra = "4"
		elseif c == "J" or c == "K" or c == "L" then
			letra = "5"
		elseif c == "M" or c == "N" or c == "O" then
			letra = "6"
		elseif c == "P" or c == "Q" or c == "R" or c == "S" then
			letra = "7"
		elseif c == "T" or c == "U" or c == "V" then
			letra = "8"
		elseif c == "W" or c == "X" or c == "Y" or c == "Z" then
			letra = "9"
		end
		saida = saida..letra
	end

	return saida
end