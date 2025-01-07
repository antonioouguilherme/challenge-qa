using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT004Step : StepBase
{
    [Given(@"que o usuário escolha o seu nível de ensino")]
    public void DadoQueOUsuarioEscolhaOSeuNivelDeEnsino()
    {
        //https://developer.grupoa.education/subscription/
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/");
    }

    [When(@"selecionar a opção 'Graduação'")]
    public void QuandoSelecionarAOpcaoGraduacao()
    {
        // Clique no combobox para abrir as opções
        driver.FindElement(By.CssSelector("[data-testid='education-level-select']")).Click();
        
        // Seleciona a opção graduação
        driver.FindElement(By.CssSelector("div[aria-labelledby='radix-vue-select-item-text-150']")).Click();


    }

    [Then(@"deve ser exibido as opções do curso de graduação")]
    public void EntaoDeveSerExibidoAsOpcoesDoCursoDeGraduacao()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector(".font-semibold.tracking-tight.text-2xl"));

        // Verificar se o texto está correto
        alertElement.Text.Should().Be("Selecione seu curso de Graduação");
    }
}