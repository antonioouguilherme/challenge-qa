Relatório de Bugs
Bug 1: Retirar a opção 'Selecione uma opção...' no momento de selecionar o nível de ensino.
Descrição: No momento de selecionar o nível de ensino, existem três opções, 'Gradução', 'Pós-Graduação' e 'Selecione uma opção...'. Ao clicar em 'Selecione uma opção...' nada acontece.
Comportamento esperado: Retirar a opção 'Selecione uma opção...' para que as pessoas não se confundam.
Passos para reproduzir: Selecionar a opção 'Selecione uma opção...'. Quando essa opção é selecionada, nada acontece.
Gravidade: Baixa.

Bug 2: Corrigir o filtro ao selecionar 'Graduação' no nível de ensino.
Descrição: Ao selecionar 'Graduação' no nível de ensino, no momento de selecionar o curso de graduação também são exibidos os cursos de mestrado, especialização e doutorado.
Comportamento esperado: Que o filtro exiba apenas os cursos de graduação.
Passos para reproduzir: Selecionar 'Graduação' no nível de ensino e clicar nas opções do cruso de graduação
Gravidade: Média.

Bug 3: Corrigir a pré seleção do nível de ensino quando se navega da tela de política de privacidade para a home.
Descrição: Ao navegar da tela de política de privacidade para a home, o nível de ensino já vem selecionado com a opção 'Graduação', porém não é possível avançar a seleção dos cursos.
Comportamento esperado: Ao navegar da tela de política de privacidade para a home que o nível de ensino não venha preenchido.
Passos para reproduzir: Na tela de política de privacidadade, clicar em 'home'
Gravidade: Grave.

Bug 4: Permitir que ao selecionar o mesmo nível de ensino, que avance para a seleção dos cursos
Descrição: Na tela de seleção do curso, quando clicar em voltar e selecionar a mesma opção do nível de ensino, não é possível avançar para a tela de seleção dos cursos
Comportamento esperado: Que ao selecionar a mesma opção no nível de ensino, que avance para a tela de selecionar o curso.
Passos para reproduzir: Selecionar graduação ou pós graduação no nível de ensino, quando for escolher o curso, clicar em voltar e selecione novamente a mesma opção no nível de ensino (Graduação ou Pós graduação).
Gravidade: Grave.

Bug 5: Acrescentar máscara no campo 'CPF' na tela dos dados cadastrais
Descrição: No campo CPF é possível colocar mais de 11 dígitos, além de aceitar texto.
Comportamento esperado: Que seja permitido preencher o campo apenas com números e com um limite máximo de 11 caracteres.
Passos para reproduzir: Preencher o campo CPF com qualquer caractere.
Gravidade: Baixa.

Bug 6: Proibir o preenchimento do campo 'Data de nascimento' com ano superior ao ano corrente na tela dos dados cadastrais.
Descrição: É possível preencher a data de nascimento com ano posterior ao ano corrente.
Comportamento esperado: Ao preencher a data de nascimento com um ano superior ao vigente, que seja exibida uma mensagem de erro.
Passos para reproduzir: Preencher a data de nascimento com um ano posterior a 2025.
Gravidade: Média.

Bug 7: Proibir que o cadastro seja validado quando o campo 'Data de nascimento' é preenchido com 'dd/mm/aaaa'.
Descrição: O cadastro é validado quando o campo 'Data de nascimento' é preenchido com os valores 'dd/mm/aaaa'
Comportamento esperado: Não permitir que o cadastro seja validado com uma data de nascimento inválida.
Passos para reproduzir: Preencher todos os campos obrigatórios do cadastro, porém, no campo 'Data de nascimento', apagar os dados que já vem preenchidos e deixar 'dd/mm/aaaa', clicar em 'Avançar'.
Gravidade: Média.

Bug 8: Acrescentar máscara no campo 'Celular' e 'Telefone' na tela dos dados cadastrais.
Descrição: Ambos os campos aceitam caracteres textuais.
Comportamento esperado: Que seja permitido preencher o campo apenas com números.
Passos para reproduzir: Preencher os campos 'Celular' e 'Telefone' com texto.
Gravidade: Baixa.

Bug 9: Sinalizar o campo 'Teleofone' como obrigatório na tela dos dados cadastrais.
Descrição: Só é possível finalizar o cadastro se preencher o campo 'Telefone', porém, ele não está sinalizado como obrigatório.
Comportamento esperado: Que o campo 'Telefone' seja sinalizado como obrigatório para o que o usuário não deixe de preencher.
Passos para reproduzir: Preencher todos os campos dos dados cadastrais, exceto o telefone e clicar em avançar.
Gravidade: Baixa.

Bug 10: Acrescentar máscara no campo 'CEP' na tela dos dados cadastrais.
Descrição: O campo CEP aceita texto.
Comportamento esperado: Que seja permitido preencher o campo apenas com números.
Passos para reproduzir: Preencher o campo CEP com qualquer caractere.
Gravidade: Baixa.

Bug 11: Exibir mensagem de invalidez para ambos os campos quando não são preenchidos na tela de autenticação.
Descrição: Quando clica em 'Login' sem preencher usuário e senha, apenas o campo da senha exibe a mensagem de inválida.
Comportamento esperado: Que a mensagem de invalidez seja exibida tanto para o campo 'Usuário' quanto para o campo 'Senha'.
Passos para reproduzir: Clicar em 'Login' sem preencher os dois campos.
Gravidade: Baixa.

Bug 12: Exibir curso na área do candidato quando o cadidato clicar em 'Minhas inscrições'
Descrição: O usuário não consegue visualizar o curso que se inscreveu quando clica em 'Minhas inscrições'.
Comportamento esperado: Que seja exibido o curso quando o usuário clicar em 'Minhas inscrições'.
Passos para reproduzir: Na área do candidato, clicar em 'Minhas inscrições'.
Gravidade: Baixa.

Bug 13: Exibir informações financeiras na área do candidato quando o cadidato clicar em 'Financeiro'.
Descrição: Na parte financeira é exibida apenas a mensagem 'content'.
Comportamento esperado: Que sejam exibidas informações financeiras quando o usuário clicar em 'Financeiro'.
Passos para reproduzir: Na área do candidato, clicar em 'Financeiro'.
Gravidade: Média.

Bug 14: Integrar o campo 'Pesquisar...' na área do candidato.
Descrição: O campo 'pesquisar' não retorna nenhum resultado ao tentar fazer uma pesquisa.
Comportamento esperado: Que seja exibido um resultado com a pesquisa realizada.
Passos para reproduzir: Na área do candidato, preencher o campo 'Pesquisar...' e dar enter.
Gravidade: Média.