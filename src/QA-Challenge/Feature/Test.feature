Feature: Validação da aplicação MaisA

    Scenario: CT001 Visualizar a tela de Politica e Privacidade
        Given que o usuario esteja na pagina inicial do portal de inscricoes
        When clicar em Privacidade
        Then sera redirecionado para a tela Politica de Privacidade

    Scenario: CT002 Escolher o nível de ensino
        Given que o usuário escolha o seu nível de ensino
        When clicar  na opção 'Selecione uma opção...'
        Then um pop-up deve ser exibido com a orientação 'Por favor, selecione um nível de ensino...'

    Scenario: CT003 Interagir com o pop-up - opção 'Selecione uma opção...'
        Given que o pou-up com a orientação 'Por favor, selecione um nível de ensino...' foi exibido
        When o usuário clicar em 'ok'
        Then o pop-up deve ser fechado

    Scenario: CT004 Escolher o nível de ensino - opção Graduação
        Given que o usuário escolha o seu nível de ensino
        When selecionar a opção 'Graduação'
        Then deve ser exibido as opções do curso de graduação
    
    Scenario: CT005 Escolher o nível de ensino - opção Pós-Graduação
        Given que o usuário escolha o seu nível de ensino
        When selecionar a opção 'Pós-Graduação'
        Then deve ser exibido as opções do curso de pós-graduação
    
    Scenario: CT006 Voltar após selecionar o nível de ensino
        Given que o usuário escolheu seu nível de ensino (graduação ou pós graduação)
        When clicar em 'voltar'
        Then voltará para o momento de escolher o nível de ensino
        
    Scenario: CT007 Avançar sem escolher um curso
        Given que o usuário escolheu seu nível de ensino (graduação ou pós graduação)
        And não escolheu um curso
        When clicar em 'Avançar'
        Then um pop-up deve ser exibido com a orientação 'Por favor, selecione um curso...'
    
    Scenario: CT008 Interagir com o pop-up - quando não selecionou um curso
        Given que o pou-up com a orientação 'Por favor, selecione um curso...' foi exibido
        When o usuário clicar em 'ok'
        Then o pop-up deve ser fechado
    
    Scenario: CT009 Avançar quando escolhe um curso
        Given que o usuário escolheu o nível de ensino
        And escolheu o curso
        When clicar em avançar
        Then será direcionado para a tela de cadastro
    
    Scenario: CT010 Avançar sem preencher os campos obrigatórios do cadastro
        Given que o usuário esteja na tela de cadastro
        And não preencheu algum campo obrigatório
        When clicar em avançar
        Then abaixo do campo obrigatório será exibida a mensagem 'Campo obrigatório'
    
    Scenario: CT011 Avançar quando preenche todos os campos obrigatórios do cadastro
        Given que o usuário preencheu todos os dados do cadastro
        When clicar em avançar
        Then será direcionado para a tela que informará seu usuário e senha
    
    Scenario: CT012 Voltar da tela de cadastro
        Given que o usuário esteja na tela de cadastro
        When clicar em 'Voltar'
        Then deverá voltar para a tela de seleção de curso
    
    Scenario: CT013 Marcar o checkbox 'Possui alguma deficiência' na tela de cadastro
        Given que o usuário marcou o checkbox 'Possui alguma deficiência'
        Then deve ser aberto o campo 'Qual deficiência' para que possa ser preenchido
        
    Scenario: CT014 Preencher o campo 'Celular' com menos de 10 caracteres na tela de cadastro
        Given que o usuário preencha o campo Celular com menos de 10 caracteres
        Then deve ser exibida a mensagem 'Devem ser informados no mínimo 10 caracteres'
        
    Scenario: CT015 Preencher o campo 'Celular' com mais de 15 caracteres na tela de cadastro
        Dado que o usuário preencha o campo Celular com mais de 15 caracteres
        Então deve ser exibida a mensagem 'Devem ser informados no máximo 15 caracteres'
        
    Scenario: CT016 Preencher o campo 'Telefone' com menos de 10 caracteres na tela de cadastro
        Given que o usuário preencha o campo Telefone com menos de 10 caracteres
        Then deve ser exibida a mensagem 'Devem ser informados no mínimo 10 caracteres'
        
    Scenario: CT017 Preencher o campo 'Telefone' com mais de 15 caracteres na tela de cadastro
        Given que o usuário preencha o campo Telefone com mais de 15 caracteres
        Then deve ser exibida a mensagem 'Devem ser informados no máximo 15 caracteres'
        
    Scenario: CT018 Acessar a tela de autenticação
        Given que o usuário esteja na tela que informe seus dados de acesso
        Then clicar em 'Acessar área do candidato'
        When será direcionado para a tela de autenticação
    
    Scenario: CT019 Clicar em login na tela de autenticação sem preencher os dados
        Given que o usuário esteja na tela de autenticação
        And não preencheu nenhum campo
        When clicar em 'Login'
        Then será informado que senha e usuário são inválidos
    
    Scenario: CT020 Recuperar usuário na tela de autenticação
        Given que o usuário esteja na tela de autenticação
        When clicar em 'Recuperar usuário'
        Then receberá uma mensagem para verificar o email
    
    Scenario: CT021 Recuperar senha na tela de autenticação
        Given que o usuário esteja na tela de autenticação
        When clicar em 'Redefinir senha'
        Then receberá uma mensagem para verificar o email
    
    Scenario: CT022 Voltar para a tela de autenticação após ter recuperado usuário ou redefinido a senha
        Given que o usuário recuperou o usuário ou redefiniu a senha
        When clicar em 'Voltar para a Home'
        Then voltará para a tela de autenticação para preencher usuário e senha
    
    Scenario: CT023 Visualizar as inscrições
        Given que o usuário esteja na área do candidato
        When clicar em 'Minhas inscrições'
        Then será direcionado para onde se encontra as incrições