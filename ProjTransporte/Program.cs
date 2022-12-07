﻿using ProjTransporte;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

var jornada = new Jornada();

var garagem = new Garagem("AAA");

var carro1 = new Veiculo("DCS8407", "Renato", 23);
var carro2 = new Veiculo("DTV4245", "Jose", 10);

jornada.AdicionarGaragem(garagem);
jornada.AdicionarVeiculo(carro1);
jornada.AdicionarVeiculo(carro2);

var seletor = new seletor(jornada);

int opcao = -1;
while (opcao != 0)
{
    opcao = seletor.EscolherOpcao();
}
