using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT010Step : StepBase
{
    [Given("que o usuário esteja na tela de cadastro")]
    public void DadoQueOUsuarioEstejaNaTelaDeCadastro()
    {
        //https://developer.grupoa.education/subscription/personal-data
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data");
    }
    
    [Given("não preencheu algum campo obrigatório")]
    public void NaopreencheuAlgumCampoObrigatorio()
    {
        // Nesse teste não vai ter preenchido nenhum campo, mas vamos focar no campo de nome
        var inputElement = driver.FindElement(By.CssSelector("[data-testid='name-input']"));

        // Verificar se o valor do campo está vazio
        inputElement.GetAttribute("value").Should().Be("");
    }
    
    [When("clicar em 'Avançar'")]
    public void QuandoClicarEmAvancar()
    {
        //Clique no botão de avançar
        driver.FindElement(By.CssSelector("[data-testid='next-button']")).Click();
    }
    
    [Then("abaixo do campo obrigatório será exibida a mensagem 'Campo obrigatório'")]
    public void EntaoAbaixoDoCampoObrigatorioSeraExibidaAMensagemCampoObrigatorio()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector(".text-sm.font-medium.text-destructive"));

        // Verificar o texto da mensagem 'Campo obrigatório'
        alertElement.Text.Should().Be("Campo obrigatório");
    }
}