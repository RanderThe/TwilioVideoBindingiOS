using System;
using TwilioVideoBindingiOS;

namespace ExemploMigracao
{
    public class ExemploTwilioVideoMigrado
    {
        public void ConfigurarAudioComOpusCodec()
        {
            // ✅ CÓDIGO ATUALIZADO - FUNCIONA COM V5.11.1
            var audioOptions = TVIAudioOptions.OptionsWithBlock(builder => 
            {
                // Usar OpusCodec em vez do IsacCodec removido
                var opusCodec = TVIOpusCodec.Create();
                builder.AudioCodecs = new TVIAudioCodec[] { opusCodec };
            });

            // Configurar conectOptions com as opções de áudio
            var connectOptions = TVIConnectOptions.OptionsWithBlock(builder => 
            {
                builder.AudioOptions = audioOptions;
                builder.RoomName = "MinhaRoom";
                // Outros parâmetros...
            });

            Console.WriteLine($"Codec configurado: Opus com DTX: {opusCodec.DtxEnabled}");
        }

        public void ExemplosAlternativosCodecs()
        {
            // Outras opções de codec disponíveis:

            // G722 Codec
            var g722Codec = TVIG722Codec.Create();
            
            // PCMA Codec  
            var pcmaCodec = TVIPcmaCodec.Create();
            
            // PCMU Codec
            var pcmuCodec = TVIPcmuCodec.Create();

            // Usar qualquer um dos codecs acima:
            var audioOptions = TVIAudioOptions.OptionsWithBlock(builder => 
            {
                // Escolha um dos codecs
                builder.AudioCodecs = new TVIAudioCodec[] { g722Codec }; 
                // ou builder.AudioCodecs = new TVIAudioCodec[] { pcmaCodec };
                // ou builder.AudioCodecs = new TVIAudioCodec[] { pcmuCodec };
            });
        }

        public void ExemploCodigoAntigo()
        {
            // ❌ ESTE CÓDIGO NÃO FUNCIONA MAIS - CAUSA ERRO DE LINKING
            /*
            var isacCodec = new TVIIsacCodec(); // Esta classe não existe mais
            var audioOptions = TVIAudioOptions.OptionsWithBlock(builder => 
            {
                builder.AudioCodecs = new TVIAudioCodec[] { isacCodec };
            });
            */

            Console.WriteLine("TVIIsacCodec foi removido na versão 5.11.1 do Twilio Video SDK");
            Console.WriteLine("Use TVIOpusCodec.Create() em vez disso.");
        }
    }
}