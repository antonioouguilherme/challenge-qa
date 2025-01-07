using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT011Step : StepBase
{
    [Given("que o usuário preencheu os dados do cadastro")]
    public void DadoQueOUsuarioPreencheuOsDadosDoCadastro()
    {
        //Tela do cadastro https://developer.grupoa.education/subscription/personal-data
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data");

        // Clicar no campo CPF e preencher
        var cpfInput = driver.FindElement(By.CssSelector("[name='cpf']"));
        cpfInput.Click();
        cpfInput.SendKeys("69036656095");
        
        //Clicar no campo Nome e preencher  
        var nomeInput = driver.FindElement(By.CssSelector("[name='name']"));
        nomeInput.Click();
        nomeInput.SendKeys("Guilherme");
        
        //Clicar no campo Sobrenome e preencher
        var sobrenomeInput = driver.FindElement(By.CssSelector("[name='surname']"));
        sobrenomeInput.Click();
        sobrenomeInput.SendKeys("Silva");
        
        // Clicar no campo Email e preencher
        var emailInput = driver.FindElement(By.CssSelector("[name='email']"));
        emailInput.Click();
        emailInput.SendKeys("teste@teste.com.br");
        
        // Clicar no campo Celular e preencher
        var celularInput = driver.FindElement(By.CssSelector("[name='cellphone']"));
        celularInput.Click();
        celularInput.SendKeys("31986746617");
        
        // Clicar no campo Telefone e preencher
        var telefoneInput = driver.FindElement(By.CssSelector("[name='phone']"));
        telefoneInput.Click();
        telefoneInput.SendKeys("3134512298");
        
        // Clicar no campo CEP e preencher
        var cepInput = driver.FindElement(By.CssSelector("[name='cep']"));
        cepInput.Click();
        cepInput.SendKeys("30622090");
        
        // Clicar no campo Endereço e preencher
        var enderecoInput = driver.FindElement(By.CssSelector("[name='address']"));
        enderecoInput.Click();
        enderecoInput.SendKeys("Rua dos Testes");
        
        // Clicar no campo Bairro e preencher
        var bairroInput = driver.FindElement(By.CssSelector("[name='neighborhood']"));
        bairroInput.Click();
        bairroInput.SendKeys("Teste");
        
        // Clicar no campo Cidade e preencher
        var cidadeInput = driver.FindElement(By.CssSelector("[name='city']"));
        cidadeInput.Click();
        cidadeInput.SendKeys("BH");
        
        // Clicar no campo Estado e preencher
        var estadoInput = driver.FindElement(By.CssSelector("[name='state']"));
        estadoInput.Click();
        estadoInput.SendKeys("MG");
        
        // Clicar no campo País e preencher
        var paisInput = driver.FindElement(By.CssSelector("[name='country']"));
        paisInput.Click();
        paisInput.SendKeys("Brasil");
    }

    [When("clicar em 'Avançar'")]
    public void QuandoClicarEmAvancar()
    {
        //Clique no botão de avançar
        driver.FindElement(By.CssSelector("[data-testid='next-button']")).Click();
    }
    
    [Then("será direcionado para a tela que informará seu usuário e senha")]
    public void EntaoSeraDirecionadoParaATelaQueInformaraSeuUsuarioESenha()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector(".font-semibold.tracking-tight.text-2xl"));

        // Verificar se o texto está correto
        alertElement.Text.Should().Be("Sua jornada começa aqui!");
    }
}