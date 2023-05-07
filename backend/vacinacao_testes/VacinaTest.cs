using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vacinacao_backend.Models;
using Xunit;

namespace vacinacao_testes {
    public class VacinaTest {
        [Fact]
        public async Task InsertVacinaTest() {
            var vacinaService = ServiceFactory.CreateVacinaService();

            var vacina = new Vacina { Titulo = "Vacina teste", Descricao = "Não fique doente", Doses = 1 };
            await vacinaService.InsertVacina(vacina);

            var vacinas = await vacinaService.FindAllVacinas();

            Assert.Single(vacinas);
            Assert.Equal("Vacina teste", vacinas[0].Titulo);
        }

        [Fact]
        public async Task DeleteVacinaTest() {
            var vacinaService = ServiceFactory.CreateVacinaService();

            var vacina = new Vacina { Titulo = "Vacina teste", Descricao = "Não fique doente", Doses = 1 };
            await vacinaService.InsertVacina(vacina);

            await vacinaService.DeleteVacina(1);

            var vacinas = await vacinaService.FindAllVacinas();

            Assert.Empty(vacinas);
        }
    }
}
