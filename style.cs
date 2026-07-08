/* ===========================
   RESET
=========================== */

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
    font-family:'Oswald',sans-serif;
}

html{
    scroll-behavior:smooth;
}

body{
    background:#081b33;
    color:#fff;
}

/* ===========================
   NAVBAR
=========================== */

.navbar{
    width:100%;
    display:flex;
    justify-content:space-between;
    align-items:center;
    padding:18px 8%;
    background:#051423;
    position:sticky;
    top:0;
    z-index:1000;
    box-shadow:0 5px 15px rgba(0,0,0,.4);
}

.logo{
    font-size:30px;
    font-weight:700;
    color:#FFD700;
}

.navbar ul{
    display:flex;
    list-style:none;
}

.navbar ul li{
    margin-left:30px;
}

.navbar ul li a{
    color:#fff;
    text-decoration:none;
    font-size:18px;
    transition:.3s;
}

.navbar ul li a:hover,
.navbar ul li a.active{
    color:#FFD700;
}

/* ===========================
   HERO
=========================== */

.hero{
    height:90vh;
    background:url("images/olympic-main.jpg") center center/cover no-repeat;
    position:relative;
}

.hero::before{
    content:"";
    position:absolute;
    inset:0;
    background:rgba(0,0,0,.60);
}

.hero-content{
    position:relative;
    z-index:2;
    max-width:700px;
    padding:140px 8%;
}

.hero-content h1{
    font-size:65px;
    color:#FFD700;
    margin-bottom:20px;
}

.hero-content p{
    font-size:20px;
    line-height:1.8;
    margin-bottom:35px;
    color:#eee;
}

.btn{
    display:inline-block;
    background:#FFD700;
    color:#000;
    padding:14px 35px;
    border-radius:40px;
    text-decoration:none;
    font-size:18px;
    font-weight:bold;
    transition:.3s;
}

.btn:hover{
    background:#fff;
    transform:translateY(-3px);
}

/* ===========================
   BREAKING NEWS
=========================== */

.breaking{
    padding:80px 8%;
}

.breaking h2{
    text-align:center;
    color:#FFD700;
    font-size:42px;
    margin-bottom:50px;
}

.breaking-container{
    display:grid;
    grid-template-columns:2fr 1fr;
    gap:35px;
}

.main-news{
    background:#102b47;
    border-radius:15px;
    overflow:hidden;
    transition:.4s;
}

.main-news:hover{
    transform:translateY(-8px);
}

.main-news img{
    width:100%;
    height:380px;
    object-fit:cover;
}

.news-text{
    padding:25px;
}

.tag{
    display:inline-block;
    background:#FFD700;
    color:#000;
    padding:6px 15px;
    border-radius:20px;
    font-size:14px;
    margin-bottom:15px;
    font-weight:bold;
}

.news-text h3{
    font-size:34px;
    margin-bottom:15px;
}

.news-text p{
    color:#ddd;
    line-height:1.8;
    margin-bottom:25px;
}

.read-btn{
    display:inline-block;
    background:#0059ff;
    color:#fff;
    text-decoration:none;
    padding:12px 30px;
    border-radius:30px;
    transition:.3s;
}

.read-btn:hover{
    background:#FFD700;
    color:#000;
}

/* ===========================
   SIDE NEWS
=========================== */

.side-news{
    display:flex;
    flex-direction:column;
    gap:20px;
}

.side-card{
    display:flex;
    align-items:center;
    background:#102b47;
    border-radius:12px;
    overflow:hidden;
    transition:.3s;
}

.side-card:hover{
    transform:translateX(8px);
}

.side-card img{
    width:120px;
    height:100px;
    object-fit:cover;
}

.side-card div{
    padding:15px;
}

.side-card h4{
    font-size:18px;
    margin-bottom:10px;
}

.side-card p{
    color:#FFD700;
    font-size:14px;
}
/* =====================================
   RESET
===================================== */

*{
    margin:0;
    padding:0;
    box-sizing:border-box;
    font-family:'Oswald',sans-serif;
}

html{
    scroll-behavior:smooth;
}

body{
    background:#07192f;
    color:#ffffff;
}

/* =====================================
   NAVBAR
===================================== */

.navbar{
    width:100%;
    display:flex;
    justify-content:space-between;
    align-items:center;
    padding:18px 8%;
    background:#061322;
    position:sticky;
    top:0;
    z-index:1000;
    box-shadow:0 4px 15px rgba(0,0,0,.4);
}

.logo{
    color:#FFD700;
    font-size:30px;
    font-weight:700;
}

.navbar ul{
    display:flex;
    list-style:none;
}

.navbar ul li{
    margin-left:30px;
}

.navbar ul li a{
    text-decoration:none;
    color:#fff;
    font-size:18px;
    transition:.3s;
}

.navbar ul li a:hover,
.navbar ul li a.active{
    color:#FFD700;
}

/* =====================================
   HERO
===================================== */

.hero{
    height:90vh;
    background:url("images/statistics-banner.jpg") center center/cover no-repeat;
    position:relative;
}

.hero::before{
    content:"";
    position:absolute;
    inset:0;
    background:rgba(0,0,0,.65);
}

.overlay{
    position:relative;
    z-index:2;
    height:100%;
    display:flex;
    flex-direction:column;
    justify-content:center;
    align-items:center;
    text-align:center;
    padding:20px;
}

.overlay h1{
    font-size:65px;
    color:#FFD700;
    margin-bottom:20px;
}

.overlay p{
    width:70%;
    font-size:20px;
    color:#f0f0f0;
    line-height:1.8;
    margin-bottom:35px;
}

.hero-btn{
    display:inline-block;
    padding:14px 35px;
    background:#FFD700;
    color:#000;
    text-decoration:none;
    border-radius:40px;
    font-weight:bold;
    transition:.3s;
}

.hero-btn:hover{
    background:#ffffff;
    transform:translateY(-4px);
}

/* =====================================
   SECTION TITLE
===================================== */

.title{
    text-align:center;
    margin-bottom:50px;
}

.title h2{
    color:#FFD700;
    font-size:42px;
    margin-bottom:10px;
}

.title p{
    color:#ddd;
    font-size:18px;
}

/* =====================================
   STATISTICS CARDS
===================================== */

.stats{
    padding:80px 8%;
}

.stats-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(240px,1fr));
    gap:30px;
}

.stat-card{
    background:#0f2a47;
    border-radius:15px;
    text-align:center;
    padding:40px 25px;
    transition:.4s;
    border:1px solid rgba(255,255,255,.08);
}

.stat-card:hover{
    transform:translateY(-10px);
    box-shadow:0 15px 35px rgba(0,0,0,.35);
}

.stat-card i{
    font-size:55px;
    color:#FFD700;
    margin-bottom:20px;
}

.stat-card h3{
    font-size:40px;
    margin-bottom:10px;
}

.stat-card span{
    color:#d8d8d8;
    font-size:18px;
}
/* ===============================
   MEDAL TABLE
================================= */

.medal-table{
    padding:80px 8%;
    background:#091f38;
}

.medal-table table{
    width:100%;
    border-collapse:collapse;
    margin-top:30px;
    overflow:hidden;
    border-radius:12px;
    background:#102b47;
}

.medal-table th{
    background:#FFD700;
    color:#000;
    padding:18px;
    font-size:18px;
    text-transform:uppercase;
}

.medal-table td{
    padding:16px;
    text-align:center;
    border-bottom:1px solid rgba(255,255,255,.08);
    color:#f2f2f2;
}

.medal-table tr:nth-child(even){
    background:#0d2440;
}

.medal-table tr:hover{
    background:#173d67;
    transition:.3s;
}

/* ===============================
   OLYMPIC RECORDS
================================= */

.records{
    padding:80px 8%;
}

.records-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(280px,1fr));
    gap:30px;
}

.record-card{
    background:#102b47;
    border-radius:15px;
    padding:30px;
    text-align:center;
    transition:.4s;
    border:1px solid rgba(255,255,255,.08);
}

.record-card:hover{
    transform:translateY(-10px);
    box-shadow:0 15px 30px rgba(0,0,0,.35);
}

.record-card i{
    font-size:55px;
    color:#FFD700;
    margin-bottom:20px;
}

.record-card h3{
    font-size:26px;
    margin-bottom:15px;
    color:#fff;
}

.record-card p{
    color:#d8d8d8;
    line-height:1.7;
}

/* ===============================
   ATHLETES
================================= */

.athletes{
    padding:80px 8%;
    background:#091f38;
}

.athlete-grid{
    display:grid;
    grid-template-columns:repeat(auto-fit,minmax(260px,1fr));
    gap:30px;
}

.athlete-card{
    background:#102b47;
    border-radius:15px;
    overflow:hidden;
    transition:.4s;
}

.athlete-card:hover{
    transform:translateY(-10px);
}

.athlete-card img{
    width:100%;
    height:300px;
    object-fit:cover;
}

.athlete-info{
    padding:20px;
}

.athlete-info h3{
    color:#FFD700;
    margin-bottom:10px;
}

.athlete-info p{
    color:#ddd;
    line-height:1.6;
}