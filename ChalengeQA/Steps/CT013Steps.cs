using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT013Step : StepBase
{
    [Given("que o usuário marcou o checkbox 'Possui alguma deficiência'")]
    public void DadoQueOUsuarioMarcouOCheckboxPossuiAlgumaDeficiencia()
    {
        //https://developer.grupoa.education/subscription/personal-data
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data");
        
        // Clicar no checkbox 
        driver.FindElement(By.CssSelector("[data-testid='has-disability-checkbox']")).Click();
    }
    
    [Then("deve ser aberto o campo 'Qual deficiência' para que possa ser preenchido")]
    public void EntaoDeveSerAbertoOCampoQualDeficienciaParaQuePossaSerPreenchido()
    {
        // Verificar se o campo está visível
        var campoDeficiencia = driver.FindElement(By.CssSelector("[name='disability']"));
        campoDeficiencia.Displayed.Should().BeTrue();
    }
}