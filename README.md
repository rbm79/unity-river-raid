# Projeto Unity: River Raid - Versão Educacional

Este projeto foi desenvolvido com Unity e C# como parte de uma série educacional para ensinar alunos a criarem um jogo simples inspirado no clássico *River Raid*. O objetivo é demonstrar, passo a passo, como criar um jogo 2D com scroll infinito, movimentação de nave e tiros, usando conceitos fundamentais de desenvolvimento de jogos.

---

## 🎓 Objetivos Educacionais

- Entender a estrutura de um projeto Unity
- Trabalhar com objetos 2D e sprites
- Criar scroll infinito com dois fundos
- Controlar uma nave com entrada do usuário
- Instanciar projéteis e adicionar movimento a eles
- Utilizar prefabs e scripts reutilizáveis

---

## 🔨 Ferramentas Utilizadas

- **Unity** 2022.3.x (ou superior)
- **Visual Studio / VS Code** para edição de scripts
- **Git + GitHub** para controle de versão

---

## 🚀 Estrutura do Projeto

```
RiverRaidProject/
├── Assets/
│   ├── Scripts/          # Scripts C# (movimentação, scroll, tiros)
│   ├── Sprites/          # Imagens usadas (nave, fundo, tiro)
│   ├── Prefabs/          # Nave e Tiro como objetos prontos para instanciar
├── ProjectSettings/      # Configurações do Unity
├── .gitignore            # Arquivos ignorados pelo Git
```

---

## 🌌 Funcionalidades Implementadas

### 1. Scroll Infinito com 2 Fundos
- Dois sprites idênticos (ex: estrelas) empilhados verticalmente
- Script `FundoScroll.cs` detecta quando um sai da tela e o reposiciona acima do outro

### 2. Controle da Nave
- Script `AviaoController.cs`
- Movimento com setas ou teclas A/D
- Limite nas bordas da tela

### 3. Disparo de Projetéteis
- `Tiro.cs`: projétil sobe continuamente após ser instanciado
- `Disparo.cs`: detecta a tecla ESPAÇO e instancia o tiro no `PontoDeDisparo`
- Corrigido problema visual com pivot e ordem de camada (`Order in Layer`)

---

## 💡 Dicas para Educadores

- Estimule os alunos a **visualizarem a Hierarquia da Cena**
- Reforce o conceito de **Prefab** como objeto reutilizável
- Demonstre como pequenos ajustes no `Pivot` ou `Order in Layer` afetam o resultado visual
- Use esse projeto como base para atividades como:
  - Adicionar inimigos
  - Criar sistema de vidas/pontuação
  - Criar HUD com UI Toolkit ou Canvas

---

## 📘 Conceitos e Técnicas Utilizadas

### 🖼️ O que são Sprites
- Sprites são **imagens 2D usadas para representar objetos visuais em jogos**, como personagens, fundos, projéteis, entre outros.
- No Unity, um sprite é um **asset de imagem (geralmente PNG)** que pode ser atribuído a um objeto por meio do componente `Sprite Renderer`.
- Sprites permitem trabalhar com animações quadro a quadro (como explosões) e compõem a base visual de jogos em 2D.


Este projeto incorpora conceitos importantes que formam a base do desenvolvimento de jogos 2D:

### 🎮 GameObject e Componentes
- Tudo em Unity é um GameObject com componentes acoplados (Transform, SpriteRenderer, Script, etc.)

### 🧱 Prefabs
- Objetos pré-configurados que podem ser instanciados dinamicamente, como os tiros

### 🎯 Input e Update
- Captura de entradas do usuário (como teclas) no método `Update()`, que é chamado a cada frame

### 🌀 Scroll infinito
- Técnica que simula movimento contínuo usando dois fundos e realocação quando um sai da tela

### 🧠 Sistema de coordenadas
- Uso correto de coordenadas locais (filhos) e globais (posição da nave e dos tiros)

### 🔃 Instanciação
- Criar objetos dinamicamente com `Instantiate()` (no disparo dos tiros)

### 🧰 Organização
- Separação de código em scripts específicos por responsabilidade (nave, tiro, fundo)

Esses fundamentos ajudam os alunos a entenderem desde o comportamento frame a frame até a composição de cenas em Unity.

---

## 🚨 Problemas comuns resolvidos

- **Tiro aparecendo atrás da nave** → resolvido com `Order in Layer` e `Position Z`
- **Tiro saindo de lugar errado** → resolvido com `PontoDeDisparo` posicionado corretamente
- **Scroll com "gaps" visuais** → resolvido com imagens ajustadas e reposicionamento relativo entre dois fundos

---

## 🎯 Possíveis próximos passos

- Sistema de colisão e destruição de inimigos
- Partículas e efeitos sonoros
- Exportação WebGL para publicar o jogo online
- Build para Android
- Animação da nave com `Animator`

---

## ✨ Melhorias visuais e técnicas futuras

Durante o desenvolvimento, discutimos outras abordagens mais avançadas para enriquecer o projeto visual e tecnicamente. Aqui estão algumas ideias que podem ser implementadas como evolução natural do jogo:

### 🔄 Estratégias de scroll alternativo:
- **Scroll com UV Offset em materiais tileables:** movimentar a textura em vez do objeto, para fundos suaves e contínuos sem reset.
- **Scroll baseado em tilemap ou tile palette:** para jogos com mapas modulares ou terrenos variados.
- **Scroll com três imagens (em vez de duas):** adiciona suavidade e evita riscos de desincronização visual.

### 🌌 Efeitos visuais adicionais:
- **Parallax:** camadas de fundo movendo-se a diferentes velocidades para criar profundidade visual (ex: nuvens, montanhas, estrelas).
- **Camadas de névoa ou sombra:** sobreposição suave entre fundos para disfarçar transições visíveis.
- **Sistema de partículas:** estrelas ou faíscas animadas para enriquecer o cenário.

### 📈 Outras melhorias possíveis:
- Power-ups e upgrades para a nave
- Tiros múltiplos ou especiais
- Tela de início e fim de jogo (menus com UI)
- Animações de explosão e feedback visual
- Música de fundo e efeitos sonoros com `AudioSource`

Essas melhorias são ótimas oportunidades para continuar ensinando novos tópicos, como física, gerenciamento de memória, arquitetura de jogos e design interativo.

---

## 📍 Repositório Oficial

[https://github.com/rbm79/unity-river-raid](https://github.com/rbm79/unity-river-raid)

---

**Desenvolvido com propósito educacional por  colaboradores.**

