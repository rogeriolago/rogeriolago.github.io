
/* Reset básico */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

/* Estilos do plano de fundo */
body.background-gif {
    background-color: #10101C; /* Cor de fundo */
    background-image: url('https://cdn.myportfolio.com/a97de94d1f8489b3887483ca1689b134/d76e4c1c-6600-46ea-9141-e93b6613c73f_rwc_0x0x500x500x4096.gif?h=347a4c772111bd4026b0348fc026e598');
    background-position: top left; /* Posiciona a imagem no canto superior esquerdo */
    background-repeat: repeat; /* Repete a imagem */
    background-size: auto; /* Mantém o tamanho original da imagem */
    color: #ffffff; /* Texto branco para contraste */
    font-family: "IBM Plex Mono", serif;
    font-weight: 400;
    font-style: normal;
    #font-family: 'Inter', sans-serif;
    line-height: 1.6;
}

/* Estilos do Menu */
.menu {
    position: relative;
    top: 0;
    left: 0;
    width: 100%;
    z-index: 1000;
    border-bottom: 0px solid rgba(255, 255, 255, 0.1); /* Borda sutil */
}

.menu .container {
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding: 10px 20px;
}

.menu .logo {
    font-size: 1.2rem;
    font-weight: 600;
    color: #ffffff;
}



.menu ul {
    align-items: center;
    list-style: none;
    font-family: "Anton", serif;
    font-weight: 400;
    font-style: normal;
    display: flex;
    gap: 20px;
    margin: 0;
    padding: 0;
    color:brown
}

.menu ul li {
    display: inline;
}

.menu ul li a {
    color: #ffffff;
    text-decoration: none;
    font-style: italic;
    font-size: 1.9rem;
    font-weight: 400;
    transition: color 0.3s ease;
}

.menu ul li.MenuHome a {
    color: #f58b13 !important;  /* Cor marrom para o item MenuHome */
    font-style: italic;
    font-size: 2.5rem;
}

.menu ul li a:hover {
    color:#f58b13 /* Azul ao passar o mouse */
}

/* Estilos do Header */
.header {
    position: relative;
    width: 100%;
    max-width: 1200px;
    margin: 0 auto;
    display: flex;
    align-items: center;
    justify-content: center;
    text-align: center;
    background-image: url('https://i.gifer.com/7UIP.gif'); /* GIF animado */
    background-size: contain; /* Cobrir toda a área */
    background-position: contain; /* Centralizar o GIF */
    color: #ffffff; /* Texto branco */
    overflow: hidden; /* Evitar transbordamento */
}

.header-overlay {
    position: absolute;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: rgba(0, 0, 0, 0.5); /* Overlay escuro semi-transparente */
    z-index: 1;
}

.header .container {
    position: relative;
    background-color: rgba(0, 0, 0, 0.7); /* Fundo semi-transparente para legibilidade */
    z-index: 2; /* Garantir que o conteúdo fique acima do overlay */
    width: 100%;
    max-width: 1200px;
    padding-top: 10%;
    padding-bottom: 10%;
}

.header h1 {
    font-size: 3rem;
    font-weight: 700;
    margin-bottom: 10px;
    color: #ffffff; /* Branco */
}

.header h2 {
    font-size: 1.5rem;
    font-weight: 400;
    margin-bottom: 5px;
    color: #cccccc; /* Cinza claro */
}

/* Container para centralizar o conteúdo */
.container {
    width: 90%;
    max-width: 1200px;
    margin: 0 auto;
    padding: 20px;
}

/* Estilos da Seção About */
.TextoDestaqueOrange{
    color: #f58b13 !important;
    text-transform: uppercase;
}
.TextoDestaqueAzul{
    color: #13f5f0 !important;
    text-transform: uppercase;
}

.about {
    padding: 60px 0;
}

.about h3 {
    font-size: 2rem;
    font-weight: 600;
    margin-bottom: 20px;
    color: #ffffff; /* Branco */
}

.about p {
    font-size: 1.1rem;
    text-align: justify;
    line-height: 1.8;
    margin-bottom: 20px;
    color: #cccccc; /* Cinza claro */
}

/* Estilos da Seção Clients */
.clients {
    padding: 60px 0;
}

.clients h3 {
    font-size: 2rem;
    font-weight: 600;
    margin-bottom: 20px;
    text-align:start;
    color: #ffffff; /* Branco */
}

.client-list {
    text-align: start;
    font-size: 1.1rem;
    color: #cccccc; /* Cinza claro */
}



/* foto home*/
.image-container {
    position: relative;
    margin: 0 auto;
    max-width: 1200px;
    width: 100%; /* Ajusta a largura do container */
}

.image-container img {

    
    display: flex;
    justify-content: center; /* Centraliza horizontalmente */
    align-items: center; /* Centraliza verticalmente */
    margin: 0 auto;
    top: 0;
    left: 0;
    justify-content: center; /* Centraliza horizontalmente */
    width: 75%; /* Faz a largura da imagem ser 100% da div */
    height: 75%; /* Faz a altura da imagem ser 100% da div */
}

/* slide*/

.wrapper{
    position:relative;
    margin:40px auto;
    border:0px solid red;
    overflow:hidden;
    height:500px;
    max-width:700px;
    border-radius:4px;
  }
  .imgList{
    position:absolute;
    list-style:none;
    margin:0;
    padding:0;
    width:1000%;
    text-align:center;  
  }
  .imgList li{
    height:100px;
    float:left;
    display:inline-block;
    background:rgba(255,255,4,.6);
    height:500px;
    width:700px;
    }
  
  .imgList li .nr{
    position:relative;
    margin:0;
    padding:0;
    top:19%;
    left:0%;
    transition:transformY(-50%) transformX(-50%);
    font-size:200px;
    color:#fff;
    text-shadow:2px 1px 1px #999;
  }
  
  .glyphicon-menu-left{
    cursor:pointer;
    position:absolute;
    left:0;
    top:45%;
    border:0px solid red;
    padding:10px;
    background:rgba(0,0,0,.5);
    color:#fff;
  }
  .glyphicon-menu-right{
    cursor:pointer;
    position:absolute;
    top:45%;
    right:0;
    border:0px solid red;
    padding:10px;
    background:rgba(0,0,0,.5);
    color:#fff;
  }
  
  .imgList li:nth-child(1){
    background:#1abc9c;
  }
  .imgList li:nth-child(2){
    background:purple;
  }
  .imgList li:nth-child(3){
    background:orange;
  }
  .imgList li:nth-child(4){
    background:indianred;
  }
  .imgList li:nth-child(5){
    background:#d35400;
  }
  .imgList li:nth-child(6){
    background:#2ecc71;
  }


/* Estilos do Footer */
.footer {
    padding: 40px 0;
    text-align: start;
}

.footer h3 {
    font-size: 1.5rem;
    font-weight: 600;
    margin-bottom: 10px;
    color: #007bff; /* Azul */
}

.footer a {
    color: #007bff;
    text-decoration: none;
}

.footer a:hover {
    text-decoration: underline;
}

/* Responsividade */
@media (max-width: 768px) {
    .menu ul {
        gap: 15px;
    }

    .menu ul li a {
        font-size: 0.9rem;
    }

    .header h1 {
        font-size: 2.5rem;
    }

    .header h2 {
        font-size: 1.2rem;
    }

    .about h3 {
        font-size: 1.8rem;
    }

    .clients h3 {
        font-size: 1.8rem;
    }

    .footer h3 {
        font-size: 1.2rem;
    }
}
