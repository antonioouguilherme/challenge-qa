using System.Runtime;
using FluentAssertions;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace ChanlegeQA.Steps;

[Binding]
public class CT015Step : StepBase
{
    [Given("que o usuário preencha o campo Celular com mais de 15 caracteres")]
    public void DadoQueOUsuarioPreenchaOCampoCelularComMaisDeQuinzeCaracteres()
    {
        //Tela do cadastro https://developer.grupoa.education/subscription/personal-data
        driver.Navigate().GoToUrl("https://developer.grupoa.education/subscription/personal-data");

        // Clicar no campo celular e preencher com mais de 15 caracteres
        var celularInput = driver.FindElement(By.CssSelector("[name='cellphone']"));
        celularInput.Click();
        celularInput.SendKeys("3198678909876546");
    }

    [Then("deve ser exibida a mensagem 'Devem ser informados no máximo 15 caracteres'")]
    public void EntaoDeveSerExibidaAMensagemDevemSerInformadosNoMaximoQuinzeCaracteres()
    {
        // Localizar o elemento com a mensagem
        var alertElement = driver.FindElement(By.CssSelector("[id='radix-176-form-item-message']"));

        // Verificar se o texto está correto
        alertElement.Text.Should().Be("Devem ser informados no máximo 15 caracteres");
    }
}