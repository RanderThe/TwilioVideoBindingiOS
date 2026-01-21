# Guia de Migração: Twilio Video iOS Binding v5.11.1

## ⚠️ Importante: TVIIsacCodec foi removido

### O que mudou?

Na versão 5.11.1 do Twilio Video iOS SDK, a classe `TVIIsacCodec` foi **removida** pela Twilio. Esta mudança afeta todos os usuários que anteriormente utilizavam este codec de áudio.

### Erro anterior:
```
Undefined symbols for architecture arm64:
  "_OBJC_CLASS_$_TVIIsacCodec", referenced from:
       in registrar.o
ld: symbol(s) not found for architecture arm64
```

### Como migrar seu código

Se você estava usando `TVIIsacCodec` em seu código, **você precisa substituir** por uma das alternativas disponíveis:

#### Opções de codec de áudio disponíveis:

1. **TVIOpusCodec** (Recomendado)
   ```csharp
   // Substitua isto:
   // var isacCodec = new TVIIsacCodec();
   
   // Por isto:
   var opusCodec = TVIOpusCodec.Create();
   ```

2. **TVIG722Codec**
   ```csharp
   var g722Codec = TVIG722Codec.Create();
   ```

3. **TVIPcmaCodec**
   ```csharp
   var pcmaCodec = TVIPcmaCodec.Create();
   ```

4. **TVIPcmuCodec**
   ```csharp
   var pcmuCodec = TVIPcmuCodec.Create();
   ```

#### Exemplo de migração completa:

**Antes (não funciona mais):**
```csharp
// CÓDIGO ANTIGO - NÃO FUNCIONARÁ MAIS
var audioOptions = TVIAudioOptions.OptionsWithBlock(builder => {
    var isacCodec = new TVIIsacCodec();
    builder.AudioCodecs = new TVIAudioCodec[] { isacCodec };
});
```

**Depois (código atualizado):**
```csharp
// CÓDIGO NOVO - USE ESTE
var audioOptions = TVIAudioOptions.OptionsWithBlock(builder => {
    var opusCodec = TVIOpusCodec.Create(); // ou outro codec de sua preferência
    builder.AudioCodecs = new TVIAudioCodec[] { opusCodec };
});
```

### Recomendação da Twilio

A Twilio recomenda usar **TVIOpusCodec** como substituto principal do TVIIsacCodec:
- Melhor qualidade de áudio
- Menor uso de largura de banda
- Suporte a DTX (Discontinuous Transmission) para economia de recursos
- Amplamente suportado

### Recursos do OpusCodec

```csharp
var opusCodec = TVIOpusCodec.Create();
bool dtxEnabled = opusCodec.DtxEnabled; // DTX ativado por padrão
```

O DTX (Discontinuous Transmission) no Opus está habilitado por padrão, resultando em economia de largura de banda e CPU durante silêncio e ruído de fundo.

## Problemas conhecidos resolvidos

✅ **Corrigido**: Erro de linking `_OBJC_CLASS_$_TVIIsacCodec`  
✅ **Corrigido**: Symbols não encontrados para arquitetura arm64  
✅ **Atualizado**: Binding compatível com Twilio Video iOS 5.11.1  

## Versão do pacote

- **Pacote NuGet**: `Video.Twilio.iOS.Binding`
- **Versão**: `5.11.1`
- **Framework**: `.NET 9 iOS`
- **Twilio Video iOS SDK**: `5.11.1`

## Suporte

Se você encontrar problemas durante a migração, verifique:

1. Que removeu todas as referências a `TVIIsacCodec`
2. Que está usando um dos codecs alternativos listados acima
3. Que está usando a versão mais recente do pacote

Para mais informações sobre os codecs de áudio disponíveis, consulte a [documentação oficial da Twilio](https://www.twilio.com/docs/video).