﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace e_LogBook.Controller
{
    public static class ControllerAudio
    {
        public enum Audios
        {
            Dano,
            Conectada,
            Cancelada,
            Entregue,
            Ts3,
            MP,
            Velocidade,
            Bip
        };

        public static void ExecutarAudio(Audios TipoDeAviso)
        {
            switch (TipoDeAviso.ToString())
            {
                case "MP":

                    SoundPlayer MP = new SoundPlayer(Properties.Resources.MP);
                    MP.Play();
                    break;
                case "Ts3":

                    SoundPlayer ts = new SoundPlayer(Properties.Resources.Ts3);
                    ts.Play();
                    break;
                case "Dano":

                    SoundPlayer Dano = new SoundPlayer(Properties.Resources.Colisao);
                    Dano.Play();

                    break;
                case "Conectada":

                    SoundPlayer Inicio = new SoundPlayer(Properties.Resources.CarregadoComSucesso);
                    Inicio.Play();

                    break;
                case "Cancelada":


                    SoundPlayer Entregue = new SoundPlayer(Properties.Resources.Cancelada);
                    Entregue.Play();

                    break;
                case "Entregue":

                    SoundPlayer Finalizada = new SoundPlayer(Properties.Resources.CargaEntregue);
                    Finalizada.Play();

                    break;
                case "Velocidade":

                    SoundPlayer Velocidade = new SoundPlayer(Properties.Resources.Camera);
                    Velocidade.Play();

                    break;
                case "Bip":

                    SoundPlayer bip = new SoundPlayer(Properties.Resources.alert);
                    bip.Play();

                    break;
            }
        }
    }
}
