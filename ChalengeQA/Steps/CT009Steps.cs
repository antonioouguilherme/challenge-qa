using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT009Step : StepBase
{
    [Given("que o usuário escolheu o seu nível de ensino")]
    public void DadoQueOUsuarioEscolheuOSeuNivelDeEnsino()
    {
        //https://developer.grupoa.education/subscription/
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");
        
        //escolher o nível de ensino - nesse caso será pós gradução
        // Clique no combobox para abrir as opções
        driver.FindElement(By.CssSelector("[data-testid='education-level-select']")).Click();
        
        // Seleciona a opção Pós-graduação
        driver.FindElement(By.CssSelector("div[aria-labelledby='radix-vue-select-item-text-151']")).Click();
    }
    
    [Given("escolheu o curso de pós-graduação")]
    public void EEscolheuOCursoDePosGraduacao()
    {
        // Seleciona a opção Mestrado em Inteligência Artificial 
        driver.FindElement(By.CssSelector("div[aria-labelledby='radix-vue-combobox-item-222']")).Click();
    }

    [When("clicar em 'Avançar'")]
    public void QuandoClicarEmAvancar()
    {
        //Clique no botão de avançar
        driver.FindElement(By.CssSelector("[data-testid='next-button']")).Click();
    }
    
    [Then( "será direcionado para a tela de cadastro")]
    public void EntaoSeraDirecionadoParaATelaDeCadastro()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector(".font-semibold.tracking-tight.text-2xl"));

        // Verificar se o texto está correto
        alertElement.Text.Should().Be("Pronto para essa aventura? Comece nos contando um pouco sobre você!");
    }
}