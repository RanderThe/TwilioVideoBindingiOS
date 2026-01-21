[![NuGet Version](https://img.shields.io/nuget/v/Video.Twilio.iOS.Binding.svg)](https://www.nuget.org/packages/Video.Twilio.iOS.Binding/) ![License](https://img.shields.io/badge/License-MIT-blue.svg)

# TwilioVideoBindingiOS

🚨 **Versão 2.0.0 - Breaking Changes** 🚨

Update to .NET 9 iOS for [TwilioVideoXamarinIOS](https://github.com/xamarin-bindings-for-twilio/TwilioVideoXamarinIOS) using [Twilio Video iOS SDK 5.11.1](https://github.com/twilio/twilio-video-ios).

## ⚠️ Mudanças Importantes na v2.0.0 (Twilio 5.11.1)

**TVIIsacCodec foi removido** do Twilio Video iOS SDK 5.11.1. Se você estava usando este codec, **você DEVE migrar seu código**.

### Solução Rápida:
```csharp
// ❌ NÃO FUNCIONA MAIS:
// var isacCodec = new TVIIsacCodec();

// ✅ USE ISTO:
var opusCodec = TVIOpusCodec.Create();
```

📖 **[Leia o Guia Completo de Migração](MIGRATION_GUIDE.md)**

## Instalação

```bash
dotnet add package Video.Twilio.iOS.Binding
```

## Requisitos

- .NET 9.0
- iOS 12.0+
- Xcode 15.0+

## Codecs Disponíveis

- ✅ **TVIOpusCodec** (Recomendado)
- ✅ **TVIG722Codec** 
- ✅ **TVIPcmaCodec**
- ✅ **TVIPcmuCodec**
- ❌ **TVIIsacCodec** (Removido na v5.11.1)
