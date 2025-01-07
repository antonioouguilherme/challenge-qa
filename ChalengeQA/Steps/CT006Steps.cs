using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT006Step : StepBase
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
    
    [When("clicar em 'voltar")]
    public void QuandoClicarEmVoltar()
    {
        // Simula o clique no botão de voltar
        driver.FindElement(By.CssSelector("[data-testid='back-button']")).Click();
    }
    
    [Then("voltará para a tela de escolha do nível de ensino")]
    public void EntaoVoltaraParaATelaDeEscolhaDoNivelDeEnsino()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector(".font-semibold.tracking-tight.text-2xl"));

        // Verificar se o texto está correto
        alertElement.Text.Should().Be("Escolha o seu nível de ensino e embarque nessa aventura!");
    }
}