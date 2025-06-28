    /********************************************/
   /********************************************/
  /*******     Grab the paper game!     *******/
 /********************************************/
/********************************************/
import ddf.minim.*;
import ddf.minim.analysis.*;
import ddf.minim.effects.*;
import ddf.minim.signals.*;
import ddf.minim.spi.*;
import ddf.minim.ugens.*;
PFont customFont;

        //Grab the paper project!!!
       //objects
  //texts
Text howmadethegamename = new Text();
Text fps = new Text();
Text percentageloadingscreen = new Text();
Text percentageloadingscreen2 = new Text();
Text Points = new Text();
Text Pointsvalue = new Text();
Text Rainbowtextstock = new Text();
Text numbergetedpapers = new Text();
  //image
Image intro = new Image();
Image threelifes = new Image();
Image twolifes = new Image();
Image onelifes = new Image();
Image zerolifes = new Image();
Image achpngicon = new Image();
Image imgpngsettingsicon = new Image();
Image imgpngsettingsicon2 = new Image();
Image imgpngsettingsicon3 = new Image();
Image betatesttext = new Image();
Image buttonplay1 = new Image();
Image buttonplay2 = new Image();
Image exitbuttonframeach = new Image();
Image settingsframeimg = new Image();
Image life3 = new Image();
Image life2 = new Image();
Image life1 = new Image();
Image achredskinbuyedlock = new Image();
Image achredskinbuyed = new Image();
Image acfirstpaper = new Image();
Image first25points = new Image();
Image achfirstpaper = new Image();
Image first150points = new Image();
Image betatester = new Image();
Image firsttimeplrplay = new Image();
Image getredpaper = new Image();
Image getbluepaper = new Image();
Image getpinkpaper = new Image();
Image getrainbowpaper = new Image();
Image getgoldpaper = new Image();
Image life0 = new Image();
Image Exitbutton = new Image();
Image Xclosetext = new Image();
Image Yesbutton = new Image();
Image Nobutton = new Image();
Image skinframe = new Image();
Image TextExitofthegame = new Image();
Image Achframe = new Image();
Image onmusic = new Image();
Image offmusic = new Image();
Image Loadingscreen = new Image();
Image buttontutorialpng = new Image();
Image buttontutorialpng2 = new Image();
Image frameendgame = new Image();
Image sadsad = new Image();
Image exitbuttonendgame = new Image();
Image buy1life = new Image();
Image tutorialframe = new Image();
Image Goodluck = new Image();
Image language = new Image();
Image Hebrew = new Image();
Image English = new Image();
Image informationbutton = new Image();
Image closebuttonframeskins = new Image();
Image Credits = new Image();
Image Messege = new Image();
Image Loading = new Image();
Image levelselect = new Image();
Image level1 = new Image();
Image specialtext = new Image();
Image level2 = new Image();
Image level3 = new Image();
Image level4 = new Image();
Image level5 = new Image();
Image level6 = new Image();
Image level7 = new Image();
Image level8 = new Image();
Image level9 = new Image();
Image level10 = new Image();
Image officebackground1 = new Image();
Image officebackground2 = new Image();
Image textplay1 = new Image();
Image textplay2 = new Image();
Image textplay3 = new Image();
Image textplay4 = new Image();
Image textplay5 = new Image();
Image textplay6 = new Image();
Image textplay7 = new Image();
Image textplay8 = new Image();
Image textplay9 = new Image();
Image textplay10 = new Image();
Image texthelp = new Image();
Image exittolobby = new Image();
Image helpframe = new Image();
Image closebuttonframehelp = new Image();
Image paper = new Image();
Image Trash = new Image();
Image skinspaperbutton = new Image();
Image skindef = new Image();
Image skinpink = new Image();
Image skinblue = new Image();
Image skinred = new Image();
Image skinrainbow = new Image();
Image skinspec = new Image();
Image Buybutton = new Image();
Image eqed = new Image();
Image rainbowskinbuy = new Image();
Image eqpp = new Image();
Image buybutton = new Image();
Image textdef = new Image();
Image textpink = new Image();
Image textblue = new Image();
Image textred = new Image();
Image textrainbow = new Image();
Image paperdefskin = new Image();
Image paperredskin = new Image();
Image paperblueskin = new Image();
Image paperpinkskin = new Image();
Image rainbowpaperskin = new Image();
Image rainbowbutton = new Image();
Image Rainbowtext = new Image();
Image lockdred = new Image();
Image lockdblue = new Image();
Image lockdpink = new Image();
Image lockdrain = new Image();
Image lockdspecial = new Image();
Image redsmalltext = new Image();
Image rainbowsmalltext = new Image();
Image spacielsmalltext = new Image();
Image bluesmalltext = new Image();
Image pinksmalltext = new Image();
Image buyredskin = new Image();
Image buyblueskin = new Image();
Image buypinkskin = new Image();
Image buyspaceilskin = new Image();
Image buyrainbowskin = new Image();
Image blueskinareyousure = new Image();
Image pinkskinareyousure = new Image();
Image redskinareyousure = new Image();
Image spacielskinareyousure = new Image();
Image rainbowskinareyousure = new Image();
Image yesbuttonbuyskin = new Image();
Image nobuttonbuyskin = new Image();
Image framenotenoughmoney = new Image();
Image closegame23 = new Image();
Image goldpaperskin = new Image();
Image closenotmoney = new Image();
Image equipp = new Image(); //--can use
Image equipped = new Image(); //-- use
Image redskinpaper = new Image();
Image blueskinpaper = new Image();
Image pinkskinpaper = new Image();
Image goldbuyskin = new Image();
Image rainbowskinpaper = new Image();
Image sdhsddf = new Image();
Image lock3 = new Image();
Image lock4 = new Image();
Image lock5 = new Image();
Image lock6 = new Image();
Image specialskinpaper = new Image();
Image blueskinbuy = new Image();
Image pinkskinbuy = new Image();
Image rianbowskinbuy = new Image();
Image goldskinbuy = new Image();
//musics!
Music lobby = new Music();
Music selctlevel46 = new Music();
Music playgame13 = new Music();
Music Papercach = new Music();
Music asjhdasd = new Music();
Music playgame48 = new Music();
Music playgame9 = new Music();
Music sedahsad = new Music();
Music sadjsafsf334g = new Music();
Music sadhsad3 = new Music();
Music buttonclick = new Music();
Music sadjkhsad = new Music();
Music playgame10 = new Music();
  //rects
Rect closebutton = new Rect();
Rect chackmusicoffon = new Rect();
Rect Blackscreen = new Rect();
Rect IntroBlock = new Rect();
Rect blockindactorpapertouch = new Rect();
Rect Blockblack = new Rect();
Rect block = new Rect();
Rect Loadingblockgame = new Rect();
Rect blacblock = new Rect();
Rect lol = new Rect();
Rect blockblackscreenbyskin = new Rect();
  //booleans int float str
boolean clickedSettings = false;
boolean clickedSettings2 = false;
boolean imageOpened = false;
boolean imageOpened2 = false;
boolean imageOpened3 = false;
boolean dsfg = false;
boolean blacscreenopened = false;
boolean alwaytrue = true;
boolean asddf = false;
boolean rotationimg = false;
boolean startthegame = true;
boolean nnnn = false;
boolean lobbymusic = true;
boolean turnofforonmusic = false;
boolean blueskinbuy1 = false;
boolean pinkskinbuy1 = false;
boolean rainbowskinbuy1 = false;
boolean goldskinbuy1 = false;
boolean musicplaygame13 = false;
boolean jsadhjbsadws = false;
boolean musicplaygame46 = false;
boolean dsn333jfhdsf = false;
boolean musicplaygame79 = false;
boolean musicplaygame10 = false;
boolean sdhsdsd = true;
boolean musicofforon = true;
boolean bookach = false;
boolean lobbymusiconoroff = true;
boolean selectlevel = false;
boolean dsiofjhds = false;
boolean dslkfjsdf = false;
boolean starttherealgame = true;
boolean widthblock3002 = false;
boolean langeuage = false; //true == hebrew,false == english
int delayonlyinintro = 0; //delay(4.5 seconds)
int widthx = 0;
int widthx2 = 0;
boolean dsfbsdf = false;
boolean widthblock300 = false;
boolean esdajfhs = false;
int percentageloadingscreenint = 0;
int percentageloadingscreenint2 = 0;
int startTime;
int duration = 5000;
boolean gamesstartboolean2 = false;
boolean redskinbuyedach = false;
float widthxfin = 0;
int randomnum = int(random(-5,5));
boolean achframe = false;
boolean endlaodingscreenrealgame = false;
boolean levelselect1 = false;
boolean levelselect2 = false;
boolean levelselect3 = false;
boolean levelselect4 = false;
boolean levelselect5 = false;
boolean hsdhef = false;
boolean levelselect6 = false;
int sec = 0;
int randomx = int(random(100,1700));
int llll = 1;
boolean saerr = false;
boolean levelselect7 = false;
boolean levelselect8 = false;
boolean levelselect9 = false;
boolean levelselect10 = false;
boolean start = false;
boolean trashxnot0 = true;
boolean start2 = false;
boolean alwaytru = true;
boolean start3 = false;
boolean start4 = false;
boolean gamestart = false;
boolean start5 = false;
boolean start6 = false;
boolean start7 = false;
boolean start8 = false;
boolean start9 = false;
boolean ghdsahusad = false;
boolean start10 = false;
boolean safrsdfh = false;
boolean trashxnot1920 = true;
boolean trashxyes1920 = false;
boolean sadhsdf456 = false;
boolean trashxnot20 = true;
boolean asd = false;
boolean movelevels = false;
int level1machpaper = 10;
int level2machpaper = 20;
int level3machpaper = 30;
int level4machpaper = 40;
int level5machpaper = 50;
int level6machpaper = 60;
int level7machpaper = 70;
int level8machpaper = 80;
int sdee = 0;
int level9machpaper = 90;
int level10machpaper = 100;
int timelevelone = 20;
int timeleveltwo = 25;
int timelevelthree = 30;
int secondsfirstpaper1 = second();
int timelevelfore = 35;
int timelevelfive = 40;
int timelevelsix = 45;
int timelevelseven = 50;
int timeleveleight = 55;
int timelevelnine = 60;
int timeleveltan = 90;
boolean texthelp3 = false;
int points;
int speeddownpaperlevel1 = 60;
boolean sdhsd = false;
int speeddownpaperlevel2 = 55;
int speeddownpaperlevel3 = 50;
int speeddownpaperlevel4 = 45;
int speeddownpaperlevel5 = 40;
int speeddownpaperlevel6 = 35;
int speeddownpaperlevel7 = 30;
int speeddownpaperlevel8 = 25;
int jjjj = 1;
int speeddownpaperlevel9 = 20;
int djsd = 0;
int speeddownpaperlevel10 = 15;
boolean skinsframeopen = false;
boolean defon = true;
boolean pinkon = false;
boolean blueon = false;
boolean jsjdjddd = true;
boolean specialon2 = false;
boolean notenoughmoney = false;
boolean sadjhsd = false;
boolean redon = false;
boolean rainbowon = false;
boolean gameend = false;
boolean lockdef = false;
boolean lockred = true;
boolean lockblue = true;
boolean lockpink = true;
boolean lockrain = true;
boolean sakjdhsiauhdfdstfnm = false;
boolean lockspecial = true;
int priceradskin = 20;
int priceblueskin = 40;
int pricepinkskin = 65;
int pricerainbowskin = 100;
int sdjsaoidcsioj = 0;
int pricespeskin = 150;
int lifes = 3;
boolean areyousurewanttobuyskinred = false;
boolean areyousurewanttobuyskinpink = false;
boolean areyousurewanttobuyskinblue = false;
boolean areyousurewanttobuyskinrainbow = false;
boolean areyousurewanttobuyskinspec = false;
boolean redskinbuyed = false;
boolean blueskinbuyed = false;
boolean pinkskinbuyed = false;
int firstpaperon = 0;
boolean paperinshape = false;
boolean rainbowskinbuyed = false;
boolean specskinbuyed = false;
boolean specialon = false;
boolean firstpaper = false;
boolean first25pointss = false;
boolean first150pointss = false;
boolean betatesterr = false;
boolean getredpaperr = false;
boolean getbluepaperr = false;
boolean firstpaper1 = false;
boolean getpinkpaperr = false;
boolean asjkhdsajhigfdewjhkl = true;
boolean getrainbowpaperr = false;
boolean sdfdsffdg = false;
boolean zajbndss = false;
boolean getgoldpaperr = false;
int timelevel1 = 25;
int oooo = 1;
boolean redequip = false;
boolean defequip = true;
boolean asjdsadsd = false;
boolean blueequip = false;
boolean pinkequip = false;
boolean rainequip = false;
boolean dsfhdsf = false;
boolean goldequip = false;
int gameendfirst = 0;
int numbergetedpapers1 = 0;
int numbergetedpapers2 = 0;
int numbergetedpapers3 = 0;
int numbergetedpapers4 = 0;
int numbergetedpapers5 = 0;
int sadhjksad = 0;
int numbergetedpapers6 = 0;
int numbergetedpapers7 = 0;
int numbergetedpapers8 = 0;
int numbergetedpapers9 = 0;
int numbergetedpapers10 = 0;


void setup() {
      //info screen and more!
  size(1920, 1080);
  PFont.list();
  PFont font;
  font = createFont("ComicSansMS-BoldItalic-48", 128);
  textFont(font);
  background(255);
  frameRate(10000);
  customFont = createFont("ComicSansMS-BoldItalic-48.vlw", 48);
        //settings objects!
  percentageloadingscreenint2 = 0;
  
  //music setting
  if (lobbymusiconoroff == true) {
    lobby.loop = true;
    lobby.load("sdjuddd.mp3");
    lobby.play();
  }
   

         //loadingscreen!
    Loadingscreen.x=0;
    Loadingscreen.y=0;
    Loadingscreen.setImage("gameloadingscreen.jpg");
    IntroBlock.x=362;
    IntroBlock.y=805;
    IntroBlock.brush = color(0);
    IntroBlock.width = 0;
    IntroBlock.height = 130;
    //text%
    percentageloadingscreen.x = 835;
    percentageloadingscreen.y = 910;
    percentageloadingscreen.brush = color(#00aacc);
    percentageloadingscreen.text =  int(percentageloadingscreenint) + "%";
    percentageloadingscreen.textSize = 120;
    percentageloadingscreen.font = "SegoeUIBlack";
    //anouther text
    percentageloadingscreen2.x = 835;
    percentageloadingscreen2.y = 910;
    percentageloadingscreen2.brush = color(#00aacc);
    percentageloadingscreen2.text =  int(percentageloadingscreenint2) + "%";
    percentageloadingscreen2.textSize = 120;
    percentageloadingscreen2.font = "SegoeUIBlack";
    //Messege
    Messege.x=0;
    Messege.y=-130;
    Messege.setImage("Textmessage.png");
       //lobby game
    //texts
  howmadethegamename.x = 950;
  howmadethegamename.y = 1020;
  howmadethegamename.brush = color(0, 0, 0);
  howmadethegamename.text = "Game made by-Jonatan";
  howmadethegamename.textSize = 60;
  howmadethegamename.font = "SegoeUIBlack";
  
  fps.x = 0;
  fps.y = 0;
  fps.brush = color(#436770);
  fps.textSize = 0;
  fps.font = "SegoeUIBlack";
  
  //imglobby
  intro.x = 0;
  intro.y = 0;
  intro.setImage("introimg.jpg");
      //buttontutorialpng
    buttontutorialpng.x=120;
    buttontutorialpng.y=850;
    buttontutorialpng.setImage("buttontutorialpng.png");
    buttontutorialpng2.x=120;
    buttontutorialpng2.y=640;
    buttontutorialpng2.setImage("buttontutorialpng2.png");
    tutorialframe.x=0;
    tutorialframe.y=0;
    tutorialframe.setImage("tutorialframeimg.jpg");
    Goodluck.x=1130;
    Goodluck.y=-200;
    Goodluck.setImage("GoodLuck!.png");
      //settings frame
    //img
  imgpngsettingsicon.x = 1100;
  imgpngsettingsicon.y = 250;
  imgpngsettingsicon.setImage("settingsicon.png");
  
  imgpngsettingsicon2.x = 1100;
  imgpngsettingsicon2.y = 250;
  imgpngsettingsicon2.setImage("settingsicon2.png");
  
  imgpngsettingsicon3.x = 1100;
  imgpngsettingsicon3.y = 250;
  imgpngsettingsicon3.setImage("settingsicon3.png");
  
  settingsframeimg.x=0;
  settingsframeimg.y=0;
  settingsframeimg.setImage("Settingsframeimg.jpg");
        //languagesettings
  language.x=180;
  language.y=350;
  language.setImage("language.png");
  //english
  English.x=800;
  English.y=600;
  English.setImage("English.png");
  //hebrew
  Hebrew.x=800;
  Hebrew.y=600;
  Hebrew.setImage("Hebrew.png");
    //buttons + Img "X"
  closebutton.x=1760;
  closebutton.y=50;
  closebutton.width=100;
  closebutton.height=100;
  closebutton.brush = color(255,0,0);
  closebutton.penThickness=5;
  blockindactorpapertouch.x=0;
  blockindactorpapertouch.y=1070;
  blockindactorpapertouch.width =1920;
  blockindactorpapertouch.height = 10;
  blockindactorpapertouch.brush = color(255,0,0);
  //information of the game 
  informationbutton.x=900;
  informationbutton.y=850;
  informationbutton.setImage("information.png");
  //Credits Game
  Credits.x=0;
  Credits.y=0;
  Credits.setImage("Credits.jpg");
  
  Xclosetext.x = 1758;
  Xclosetext.y = 50;
  Xclosetext.setImage("closebutton.png");
  //Xclosetext.brush = color(255);
  //Xclosetext.text = "X";
  //Xclosetext.textSize = 100;
  //Xclosetext.font = "ComicSansMS-BoldItalic";

  //buttonplay 1 and 2:
  //1
  buttonplay1.x = 270; //270
  buttonplay1.y = 230;
  buttonplay1.setImage("Greenbuttonplay.png");
  
  //2
  buttonplay2.x = 5555;
  buttonplay2.y = 880;
  buttonplay2.setImage("Greenbuttonplay2.png");
  
  // Generate a random boolean value for clickedSettings using a while loop!!
  while(true) {
    int randomnum = int(random(2)); 
    if(randomnum == 0) {
      clickedSettings = false;
    } else if (randomnum == 1) {
      clickedSettings = true;
    }
    break; 
  }
  //sad
  sadsad.x = 1450;
  sadsad.y= 1100;
  sadsad.setImage("sssssa.png");
   //exit of the game
  Exitbutton.x = 800;
  Exitbutton.y = 925;
  Exitbutton.setImage("Exitbutton.png");
  block.x=0;
  block.y=0;
  block.brush = color(0);
  block.width = 2;
  block.height = 2000;
   //frame are you sure want exit of the game?
  Nobutton.x = 1200;
  Nobutton.y = 650;
  Yesbutton.setImage("Yesbuttongreen.png");
  Yesbutton.x = 450;
  Yesbutton.y = 650;
  Nobutton.setImage("Nobuttonred.png");
  Blackscreen.x=0;
  Blackscreen.y=0;
  Blackscreen.width=1920;
  Blackscreen.height=1080;
  //Blackscreen.alpha = 230;
  Blackscreen.brush = color(0);
  TextExitofthegame.x=-75;
  TextExitofthegame.y=-350;
  TextExitofthegame.setImage("TextExitofthegame!.png");
  //loadingrealgamesettings
  Loading.x=0;
  Loading.y=0;
  Loading.setImage("Loading.jpg");
  Loadingblockgame.x=310;
  Loadingblockgame.y=639;
  Loadingblockgame.width=0;
  Loadingblockgame.height=135;
  Loadingblockgame.brush = color(#ffba00);
  //lifes 
  life3.x=50;
  life3.y=200;
  life3.setImage("3lifes.png");
  life2.x=50;
  life2.y=200;
  life2.setImage("2lifes.png");
  life1.x=50;
  life1.y=200;
  life1.setImage("1lifes.png");
 life0.x=50;
  life0.y=200;
 life0.setImage("0lifes.png");
  //levels frame
  levelselect.x=0;
  levelselect.y=0;
  levelselect.setImage("levelselect.jpg");
  level1.x=240; //120
  level1.y=235;
  level1.setImage("level1.png");
  level2.x=530;
  level2.y=235;
  level2.setImage("level2.png");
  level3.x=820;
  level3.y=235;
  level3.setImage("level3.png");
  level4.x=1110;
  level4.y=235;
  level4.setImage("level4.png");
  level5.x=1400;
  level5.y=235;
  level5.setImage("level5.png");
    //row 2
  level6.x=240;
  level6.y=570;
  level6.setImage("level6.png");
  level7.x=530;
  level7.y=570;
  level7.setImage("level7.png");
  level8.x=820;
  level8.y=570;
  level8.setImage("level8.png");
  level9.x=1110;
  level9.y=570;
  level9.setImage("level9.png");
  level10.x=1400;
  level10.y=570;
  level10.setImage("level10.png");
  //image play officebackground 1 and 2 
  officebackground1.x=0;
  officebackground1.y=0;
  officebackground1.setImage("officebackground1.jpg");
  officebackground2.x=0;
  officebackground2.y=0;
  officebackground2.setImage("officebackground2.jpg");
  //texts play
  textplay1.x=700;
  textplay1.y=-300;//-100
  textplay1.setImage("textlevel1.png");
   textplay2.x=700;
  textplay2.y=-300;
  textplay2.setImage("textlevel2.png");
   textplay3.x=700;
  textplay3.y=-300;
  textplay3.setImage("textlevel3.png");
   textplay4.x=700;
  textplay4.y=-300;
  textplay4.setImage("textlevel4.png");
   textplay5.x=700;
  textplay5.y=-300;
  textplay5.setImage("textlevel5.png");
   textplay6.x=700;
  textplay6.y=-300;
  textplay6.setImage("textlevel6.png");
   textplay7.x=700;
  textplay7.y=-300;
  textplay7.setImage("textlevel7.png");
   textplay8.x=700;
  textplay8.y=-300;
  textplay8.setImage("textlevel8.png");
   textplay9.x=700;
  textplay9.y=-300;
  textplay9.setImage("textlevel9.png");
   textplay10.x=700;
  textplay10.y=-300;
  textplay10.setImage("textlevel10.png");
  //beta test text!
  betatesttext.x=125;
  betatesttext.y=925;
  betatesttext.setImage("Betatesttext.png");
  //images help general
  texthelp.x=10;
  texthelp.y=5;
  texthelp.setImage("texthelp.png");
  exittolobby.x=0;
  exittolobby.y=1000;
  exittolobby.setImage("exitbuttontolobby.png");
  helpframe.x=300;
  helpframe.y=300;
  helpframe.setImage("helpframe.png");
  blacblock.x=0;
  blacblock.y=0;
  blacblock.width = 1920;
  blacblock.height = 1080;
  blacblock.brush = color(0);
  blacblock.alpha = 170;
  closebuttonframehelp.x=1365;
  closebuttonframehelp.y=330;//330
  closebuttonframehelp.setImage("closebuttonframehelp.png");
  Blockblack.x=0;
  Blockblack.y=0;
  Blockblack.height = 1080;
  Blockblack.width = 1920;
  Blockblack.alpha = 0;
  //game play!
  //papersettings
  paper.x = randomx;  
  paper.y=0;
  paper.setImage("Paper.png");
  redskinpaper.x = randomx;  
  redskinpaper.y=0;
  redskinpaper.setImage("redpaperskin.png");
  blueskinpaper.x = randomx;  
  blueskinpaper.y=0;
  blueskinpaper.setImage("bluepaperskin.png");
  pinkskinpaper.x = randomx;  
  pinkskinpaper.y=0;
  pinkskinpaper.setImage("pinkpaperskin.png");
  rainbowskinpaper.x = randomx;  
  rainbowskinpaper.y=0;
  rainbowskinpaper.setImage("rainbowpaperskin.png");
   specialskinpaper.x = randomx;  
  specialskinpaper.y=0;
  specialskinpaper.setImage("goldpaperskin.png");
  //ifes
  frameendgame.setImage("framegameend.jpg");
  frameendgame.x=0;
  frameendgame.y=0;
  exitbuttonendgame .setImage("exitbuttonendgame.png");
  exitbuttonendgame.x=800;
  exitbuttonendgame.y=600;
  buy1life .setImage("buylife.png");
  buy1life.x=400;
  buy1life.y=600;
  //trashsettings
  Trash.x=680;
  Trash.y=960;
  Trash.setImage("Trash.png");
  lol.x=3500;
  lol.y=3500;
  lol.brush = color(0); //0
  lol.alpha = 255;//alpha = 1
  lol.width = 450;
  lol.height = 100; 
  Points.x = 30;
  Points.y = 110;
    Points.brush = color(0, 233, 241);
  //Points.brush = color(202, 185, 241);
  Points.text = "Points: "+ points;
  Points.textSize = 45;
  Points.font = "SegoeUIBlack";
  //textures
  skinspaperbutton.setImage("skinsbuttonpaper.png");
  skinframe.x=0;
  skinframe.y=0;
  skinframe.setImage("paperskinsframee.jpg");
  closebuttonframeskins.x=1750;
  closebuttonframeskins.y=25;
  closebuttonframeskins.setImage("closeskinframe.png");
  //skins
  skinblue.x=2500; //922
  skinblue.y=2500; //420
  skinblue.setImage("skinblue.png");
  skinpink.x=2500; //178
  skinpink.y=2500; //800
  skinpink.setImage("skinpink.png");
  skinred.x=2500;
  skinred.y=2500;
  skinred.setImage("skinred.png");
  skinrainbow.x=2500; //540
  skinrainbow.y= 2500; //800
  skinrainbow.setImage("rainbowskin.png");
  skinspec.x=2500; //922
  skinspec.y=2500; //800
  skinspec.setImage("specialskin.png");
  skindef.x=178;
  skindef.y=420;
  skindef.setImage("skindefault.png");
  buybutton.x=2500;
  buybutton.y=900;
  buybutton.setImage("buyskinbutton.png");
  textpink.x=1280;
  textpink.y=50;
  textpink.setImage("pinktext.png");
  textred.x=1280;
  textred.y=50;
  textred.setImage("redtext.png");
  specialtext.x=1280;
  specialtext.y=50;
  specialtext.setImage("spacieltext.png");
  textblue.x=1280;
  textblue.y=50;
  textblue.setImage("bluetext.png");
  textdef.x=1280;
  textdef.y=50;
  textdef.setImage("defaulttext.png");
  paperredskin.x=1470;
  paperredskin.y=505;
  paperredskin.setImage("redpaperskin.png");
  paperpinkskin.x=1470;
  paperpinkskin.y=505;
  paperpinkskin.setImage("pinkpaperskin.png");
  paperblueskin.x=1470;
  paperblueskin.y=505;
  paperblueskin.setImage("bluepaperskin.png");
  goldpaperskin.x=1470;
  goldpaperskin.y=505;
  goldpaperskin.setImage("goldpaperskin.png");
  paperdefskin.x=1470;
  paperdefskin.y=505;
  paperdefskin.setImage("defpaperskin.png");
  rainbowbutton.y=780;
  rainbowbutton.x=540;
  rainbowbutton.setImage("rainbowskin.png");
  rainbowpaperskin.x=1470;
  rainbowpaperskin.y=505;
  rainbowpaperskin.setImage("rainbowpaperskin.png");
  Rainbowtext.x=1280;
  Rainbowtext.y=50;
  Rainbowtext.setImage("Rainbowtext.png");
  Pointsvalue.x=100;
  Pointsvalue.y=100;
  Pointsvalue.brush = color(255,255,255);
  Pointsvalue.text = "Points: " + points;
  textFont(customFont);
  Pointsvalue.textSize = 60;
  Rainbowtextstock.x=2500;
  Rainbowtextstock.y=100;
  Rainbowtextstock.brush = color(0,0,0);
  Rainbowtextstock.text = "Points: " + points;
  Rainbowtextstock.alpha = 50;
  textFont(customFont);
  Rainbowtextstock.textSize = 65;
  lockdred.x=514;
  lockdred.y=270;
  lockdred.setImage("lock.png");
  lockdblue.x=895;
  lockdblue.y=270;
  lockdblue.setImage("lock.png");
  lockdpink.x=157;
  lockdpink.y=646;
  lockdpink.setImage("lock.png");
  lockdrain.x=514;
  lockdrain.y=646;
  lockdrain.setImage("lock.png");
  lockdspecial.x=895;
  lockdspecial.y=646;
  lockdspecial.setImage("lock.png");
  redsmalltext.x=578;
  redsmalltext.y=275;
  redsmalltext.setImage("redsmalltext.png");
  pinksmalltext.x=200;
  pinksmalltext.y=665;
  pinksmalltext.setImage("pinksmalltext.png");
  rainbowsmalltext.x=527;
  rainbowsmalltext.y=665;
  rainbowsmalltext.setImage("rainbowsmalltext.png");
  bluesmalltext.x=940;
  bluesmalltext.y=redsmalltext.y;
  bluesmalltext.setImage("bluesmalltext.png");
  spacielsmalltext.x=bluesmalltext.x-27;
  spacielsmalltext.y=rainbowsmalltext.y;
  spacielsmalltext.setImage("spacielsmalltext.png");
  buyredskin.x=518;
  buyredskin.y=530;
  buyredskin.setImage("Buy.png");
  buyblueskin.x=900;
  buyblueskin.y=530;
  buyblueskin.setImage("Buy.png");
  buypinkskin.x=160;
  buypinkskin.y=905;
  buypinkskin.setImage("Buy.png");
  buyrainbowskin.x=buyredskin.x;
  buyrainbowskin.y=905;
  buyrainbowskin.setImage("Buy.png");
  buyspaceilskin.x = buyblueskin.x;
  buyspaceilskin.y = buyrainbowskin.y;
  buyspaceilskin.setImage("Buy.png");
  blockblackscreenbyskin.x=0;
  blockblackscreenbyskin.y=0;
  blockblackscreenbyskin.brush = color(0);
  blockblackscreenbyskin.alpha = 170;
  blockblackscreenbyskin.width = 1920;
  blockblackscreenbyskin.height = 1080;
  blueskinareyousure.x=0;
  blueskinareyousure.y=0;
  blueskinareyousure.setImage("blueskinareyousure.png");
  redskinareyousure.x=0;
  redskinareyousure.y=0;
  redskinareyousure.setImage("redskinareyousure.png");
  pinkskinareyousure.x=0;
  pinkskinareyousure.y=0;
  pinkskinareyousure.setImage("pinkskinareyousure.png");
  rainbowskinareyousure.x=0;
  rainbowskinareyousure.y=0;
  rainbowskinareyousure.setImage("rainbowskinareyousure.png");
  spacielskinareyousure.x=0;
  spacielskinareyousure.y=0;
  spacielskinareyousure.setImage("spacielskinareyousure.png");
  yesbuttonbuyskin.x=600;
  yesbuttonbuyskin.y=680;
  yesbuttonbuyskin.setImage("Yesbuttongreen.png");
  nobuttonbuyskin.x=1000;
  nobuttonbuyskin.y=yesbuttonbuyskin.y;
  nobuttonbuyskin.setImage("Nobuttonred.png");
  numbergetedpapers.x=40;
  numbergetedpapers.y=180;
  numbergetedpapers.brush = color(255,0,0);
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  //numbergetedpapers.text = "number geted papers: " + numbergetedpapers1;
  numbergetedpapers.textSize = 45;
  framenotenoughmoney.x=0;
  framenotenoughmoney.y=0;
  framenotenoughmoney.setImage("framenotenoughmoney.png");
  closenotmoney.x=1529;
  closenotmoney.y=108;
  closenotmoney.setImage("closenotmoney.png");
  equipp.x=1340;
  equipp.y=890;
  equipp.setImage("Equippbutton.png");
  equipped.x=1340;
  equipped.y=890;
  equipped.setImage("equippedbutton.png");
  eqpp.x=1340;
  eqpp.y=890;
  eqpp.setImage("Equippbutton.png");
  closegame23.x=2500; //1760
  closegame23.y=25; //25
  closegame23.setImage("closegame23.png");
  //achframe
  achpngicon.x=3000;
  achpngicon.y=3000;
  achpngicon.setImage("achpngicon.png");
  Achframe.x=0;
  Achframe.y=0;
  Achframe.setImage("Achframe.jpg");
  exitbuttonframeach.x = 820;
  exitbuttonframeach.y= 950;
  exitbuttonframeach.setImage("exitsadhjsajd.png");
  achfirstpaper.x = 125;
  achfirstpaper.y = 225;
  achfirstpaper.setImage("sadhsad.png");
  sdhsddf.x=125;
  sdhsddf.y=225;
  sdhsddf.setImage("locks.png");
  achredskinbuyed.x = 470; //470 - 125 = 345
  achredskinbuyed.y = 225;
  achredskinbuyed.setImage("achredskinbuyed.png");
  achredskinbuyedlock.x = 470;
  achredskinbuyedlock.y = 225;
  achredskinbuyedlock.setImage("lockoiuiodsjf.png");
  blueskinbuy.x = 815; //470 + 345 = 815
  blueskinbuy.y = 225;
  blueskinbuy.setImage("youbuyblueskin.png");
  pinkskinbuy.x = 1160;  
  pinkskinbuy.y = 225;
  pinkskinbuy.setImage("youbuypinkskin.png");
  rainbowskinbuy.x = 125;
  rainbowskinbuy.y = 550; //550 - 225 = 325y
  rainbowskinbuy.setImage("youbuyrainbowskin.png");
  goldbuyskin.x = 470; 
  goldbuyskin.y = 550;
  goldbuyskin.setImage("youbuygoldskin.png");
  lock3.x=blueskinbuy.x;
  lock3.y=blueskinbuy.y;
  lock3.setImage("locks.png");
  lock4.x=pinkskinbuy.x;
  lock4.y=pinkskinbuy.y;
  lock4.setImage("locks.png");
  lock5.x=rainbowskinbuy.x;
  lock5.y=rainbowskinbuy.y;
  lock5.setImage("locks.png");
  lock6.x=goldbuyskin.x;
  lock6.y=goldbuyskin.y;
  lock6.setImage("locks.png");
  //musiconoff
  onmusic.x = 685;
  onmusic.y= 290;
  onmusic.setImage("Onmusic.png");
  offmusic.x=onmusic.x;
  offmusic.y=onmusic.y;
  offmusic.setImage("Offmusic.png");
  chackmusicoffon.x = onmusic.x;
  chackmusicoffon.width = 222;
  chackmusicoffon.height = 96;
  chackmusicoffon.y = onmusic.y;
  chackmusicoffon.alpha = 1;
  //save data
  while(sdee == 0){
       String[] data = loadStrings("savedata.txt");
       points = int(data[0]);
       //firstpaperon = int(data[2]);
       println("Data loaded!");
       break;
   }
   //achinfo
   acfirstpaper.x=-100;
   acfirstpaper.y = 50;
   acfirstpaper.setImage("firstpaperac.png");
   //startTime = millis(); 
   startTime = millis(); 
}


void draw() {
         //music
 if (lobbymusiconoroff == false) {
  //print("stop");
    lobby.stop();
  }
  if(selectlevel == false){
    //print("stop");
    selctlevel46.stop();
  }
    if(selectlevel == true && dslkfjsdf == false){
     dslkfjsdf = true;
    selctlevel46.loop = true;
    selctlevel46.load("selectlevelmusic.mp3");
    selctlevel46.play();
 }
 if(jsadhjbsadws == true && esdajfhs == false){
   selectlevel = false;
  //print("on");
    esdajfhs = true;
   playgame13.loop = true;
   playgame13.load("asdjhasd.mp3");
   playgame13.play();
 }
 
  if(sakjdhsiauhdfdstfnm == true && esdajfhs == false){
   selectlevel = false;
   esdajfhs = true;
  //print("on");
   sadjsafsf334g.loop = true;
   sadjsafsf334g.load("sssss.mp3");
   sadjsafsf334g.play();
 }
 
   if(sadjhsd == true && esdajfhs == false){
   selectlevel = false;
  //print("on");
    esdajfhs = true;
   sadjkhsad.loop = true;
   sadjkhsad.load("asdljsdf.mp3");
   sadjkhsad.play();
 }
 
   if(hsdhef == true && esdajfhs == false){
   selectlevel = false;
  //print("on");
    esdajfhs= true;
   sadhsad3.loop = true;
   sadhsad3.load("sdaj3.mp3");
   sadhsad3.play();
 }
 
 if(ghdsahusad == true && dsfbsdf == false){
   sadhsad3.stop();
   sadjkhsad.stop();
   dsfbsdf = true;
   sadjkhsad.stop();
   sadjsafsf334g.stop();
   playgame13.stop();
   selctlevel46.stop();
   lobby.stop();
  selectlevel = false;
 // print("on");
    esdajfhs= true;
   sedahsad.loop = false;
   sedahsad.load("sadejnshdh.mp3");
   sedahsad.play();
 }
  //end music setting
  
     if (startthegame == false){
      intro.draw();
     }
   //paperskins
  if ((mouseButton == LEFT) && (mouseX >= skinspaperbutton.x && mouseX <= skinspaperbutton.x + skinspaperbutton.width &&
    mouseY >= skinspaperbutton.y && mouseY <= skinspaperbutton.y + skinspaperbutton.height)) {
      dsn333jfhdsf = false;
        buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();

    skinsframeopen = true;
 }
  if ((mouseButton == LEFT) && (mouseX >= closebuttonframeskins.x && mouseX <= closebuttonframeskins.x + closebuttonframeskins.width &&
    mouseY >= closebuttonframeskins.y && mouseY <= closebuttonframeskins.y + closebuttonframeskins.height) && dsn333jfhdsf == false) {
        dsn333jfhdsf = true;
      buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
    skinsframeopen = false;
 }
 if (skinsframeopen == true){
   //print("open");
  skinframe.draw();
  closebuttonframeskins.draw();
  skindef.draw();
  redsmalltext.draw();
  bluesmalltext.draw();
  pinksmalltext.draw();
  rainbowsmalltext.draw();
  spacielsmalltext.draw();
  //rainbowbutton.draw();
  rainbowbutton.x=2500;
 //skinblue.draw();
  //skinred.draw();
  //skinpink.draw();
  //buybutton.draw();
  Rainbowtextstock.draw();
  Pointsvalue.text = "Points: " + points;
  Pointsvalue.draw();
  while (skinsframeopen == true){
          Pointsvalue.draw();
            Pointsvalue.text = "Points: " + points;
         break;}
  //ifs
    if ((mouseButton == LEFT) && (mouseX >= skindef.x && mouseX <= skindef.x + skindef.width &&
    mouseY >= skindef.y && mouseY <= skindef.y + skindef.height)) {
    print("def");
    defon = true;
      pinkon = false;
     blueon = false;
     redon = false;
 }
     if ((mouseButton == LEFT) && (mouseX >= rainbowbutton.x && mouseX <= rainbowbutton.x + rainbowbutton.width &&
    mouseY >= rainbowbutton.y && mouseY <= rainbowbutton.y + rainbowbutton.height)) {
    print("rainbowbutton");
    rainbowon = true;
    defon = false;
      pinkon = false;
     blueon = false;
     redon = false;
 }
  if ((mouseButton == LEFT) && (mouseX >= skinblue.x && mouseX <= skinblue.x + skinblue.width &&
    mouseY >= skinblue.y && mouseY <= skinblue.y + skinblue.height)) {
     print("Blue");
    blueon = true;
      pinkon = false;
     defon = false;
     redon = false;
 }
  if ((mouseButton == LEFT) && (mouseX >= skinred.x && mouseX <= skinred.x + skinred.width &&
    mouseY >= skinred.y && mouseY <= skinred.y + skinred.height)) {
    print("Red");
    redon = true;
     pinkon = false;
     defon = false;
     blueon = false;
}
  if ((mouseButton == LEFT) && (mouseX >= skinpink.x && mouseX <= skinpink.x + skinpink.width &&
    mouseY >= skinpink.y && mouseY <= skinpink.y + skinpink.height)) {
    print("Pink");
    pinkon = true;
     defon = false;
     blueon = false;
     redon = false;
 }
 if ((mouseButton == LEFT) && (mouseX >= skinrainbow.x && mouseX <= skinrainbow.x + skinrainbow.width &&
    mouseY >= skinrainbow.y && mouseY <= skinrainbow.y + skinrainbow.height)) {
    print("rainbow");
    specialon = false;
    rainbowon = true;
    pinkon = false;
     defon = false;
     blueon = false;
     redon = false;
 }
 if ((mouseButton == LEFT) && (mouseX >= skinspec.x && mouseX <= skinspec.x + skinspec.width &&
    mouseY >= skinspec.y && mouseY <= skinspec.y + skinspec.height)) {
    print("special");
    specialon2 = true;
    specialon = true;
    pinkon = false;
     defon = false;
     blueon = false;
     rainbowon = false;
     redon = false;
 }
 //ach
 if(nnnn == true && firstpaper == false){
  firstpaper = true;
  print("firstpapertrue");
 }
 //locks
  if (lockred == true){
    lockdred.draw();
     redsmalltext.draw();
     buyredskin.draw();
  }
    if (lockblue == true){
    lockdblue.draw();
     bluesmalltext.draw();
     buyblueskin.draw();
  }
    if (lockpink == true){
    lockdpink.draw();
     pinksmalltext.draw();
     buypinkskin.draw();
  }
    if (lockrain == true){
    lockdrain.draw();
     rainbowsmalltext.draw();
     buyrainbowskin.draw();
  }
    if (lockspecial == true){
    lockdspecial.draw();
    spacielsmalltext.draw();
    buyspaceilskin.draw();
  }
   //-saddd
   if (defon == true && skinsframeopen == true) {
        pinkon = false;
      rainbowon = false;
      redon = false;
      blueon = false;
         specialon = false;
   rainbowon = false;
     textdef.draw();
     paperdefskin.draw();
   }
   
  
   //equip and equiped
   if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
    mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && redon == true)){
      redequip = true;
    }
   if (defequip == true && defon == true && skinsframeopen == true){
      equipped.draw();}
      else if (defequip == false && defon == true && skinsframeopen == true){
       eqpp.draw();}
       
     if (redequip == true && redon == true && skinsframeopen == true){
      blueequip = false;
      pinkequip = false;
      rainequip = false;
      goldequip = false;
      equipped.draw();}
      else if (defequip == false && defon == true && skinsframeopen == true){
       equipp.draw();}
       
    if (pinkon == true && skinsframeopen == true) {
        defon = false;
      rainbowon = false;
      redon = false;
      blueon = false;
         specialon = false;
   rainbowon = false;
     textpink.draw();
     paperpinkskin.draw();
   }
      if (redon == true && skinsframeopen == true && lockred == false) {
      defon = false;
      rainbowon = false;
      pinkon = false;
      blueon = false;
         specialon = false;
   rainbowon = false;
     textred.draw();
     paperredskin.draw();
   }
      if (blueon == true && skinsframeopen == true) {
      defon = false;
      rainbowon = false;
      pinkon = false;
      redon = false;
       specialon = false;
   rainbowon = false;
     textblue.draw();
     paperblueskin.draw();
   }
    if (rainbowon == true && skinsframeopen == true) {
      defon = false;
      blueon = false;
      pinkon = false;
      redon = false;
      specialon = false;
     Rainbowtext.draw();
     rainbowpaperskin.draw();
   }
     if (specialon == true && skinsframeopen == true) {
      defon = false;
      blueon = false;
      pinkon = false;
      redon = false;
      rainbowon = false;
     specialtext.draw();
     goldpaperskin.draw();
   }

  if ((mouseButton == LEFT) && (mouseX >= buyredskin.x && mouseX <= buyredskin.x + buyredskin.width &&
     mouseY >= buyredskin.y && mouseY <= buyredskin.y + buyredskin.height)){
       areyousurewanttobuyskinred = true;
         areyousurewanttobuyskinblue = false;
       areyousurewanttobuyskinpink = false;
       areyousurewanttobuyskinrainbow = false;
       areyousurewanttobuyskinspec = false;
  }
    if ((mouseButton == LEFT) && (mouseX >= buyblueskin.x && mouseX <= buyblueskin.x + buyblueskin.width &&
     mouseY >= buyblueskin.y && mouseY <= buyblueskin.y + buyblueskin.height)){
       areyousurewanttobuyskinblue = true;
       areyousurewanttobuyskinpink = false;
       areyousurewanttobuyskinrainbow = false;
       areyousurewanttobuyskinspec = false;
  }
    if ((mouseButton == LEFT) && (mouseX >= buypinkskin.x && mouseX <= buypinkskin.x + buypinkskin.width &&
     mouseY >= buypinkskin.y && mouseY <= buypinkskin.y + buypinkskin.height)){
       areyousurewanttobuyskinpink = true;
       areyousurewanttobuyskinblue = false;
       areyousurewanttobuyskinrainbow = false;
       areyousurewanttobuyskinspec = false;
  }
    if ((mouseButton == LEFT) && (mouseX >= buyrainbowskin.x && mouseX <= buyrainbowskin.x + buyrainbowskin.width &&
     mouseY >= buyrainbowskin.y && mouseY <= buyrainbowskin.y + buyrainbowskin.height)){
       areyousurewanttobuyskinrainbow = true;
       areyousurewanttobuyskinblue = false;
       areyousurewanttobuyskinpink = false;
       areyousurewanttobuyskinspec = false;
  }
    if ((mouseButton == LEFT) && (mouseX >= buyspaceilskin.x && mouseX <= buyspaceilskin.x + buyspaceilskin.width &&
     mouseY >= buyspaceilskin.y && mouseY <= buyspaceilskin.y + buyspaceilskin.height)){
       areyousurewanttobuyskinspec = true;
              areyousurewanttobuyskinblue = false;
       areyousurewanttobuyskinpink = false;
       areyousurewanttobuyskinrainbow = false;
  }
  //ffffffffffffffff
  //skinred
if ((mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height 
     && areyousurewanttobuyskinred == true && points >= priceradskin)) {
      //change x and y
    skinred.x=540;
    redskinbuyedach = true;
    skinred.y=420;
   points = points - 20;
   Pointsvalue.text = "points: " + points;
   Pointsvalue.draw();
   print("points:"+ points);
   redskinbuyed = true;
   areyousurewanttobuyskinred = false;
   println("plr buy red skin!");
} else if (points <= priceradskin && (mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinred == true && points <= priceradskin)) {
    notenoughmoney = true;
   println("plr dont have enough money to buy this skin!");
} else if ((mouseButton == LEFT) && (mouseX >= nobuttonbuyskin.x && mouseX <= nobuttonbuyskin.x + nobuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= nobuttonbuyskin.y + nobuttonbuyskin.height && areyousurewanttobuyskinred == true)) {
    areyousurewanttobuyskinred = false;
   println("plr dont want to buy this skin *cry*");
}
 //skinblue
if ((mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinblue == true && points >= priceradskin)) {
      skinblue.x=922;
      skinblue.y=420;
   points -= priceblueskin;
   blueskinbuy1 = true;
   Pointsvalue.text = "points: " + points;
   blueskinbuyed = true;
   areyousurewanttobuyskinblue = false;
   println("plr buy blue skin!");
} else if (points <= priceblueskin && (mouseButton == LEFT) && 
(mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height 
     && areyousurewanttobuyskinblue == true && points <= priceblueskin)) {
    notenoughmoney = true;
   println("plr dont have enough money to buy this skin!");
} else if ((mouseButton == LEFT) && (mouseX >= nobuttonbuyskin.x && mouseX <= nobuttonbuyskin.x + nobuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= nobuttonbuyskin.y + nobuttonbuyskin.height && areyousurewanttobuyskinblue == true)) {
    areyousurewanttobuyskinblue = false;
   println("plr dont want to buy this skin *cry*");
}


  //skinspec
if ((mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinspec == true &&
      points >= pricespeskin)) {
        //sad
        skinspec.x=922;
           goldskinbuy1 = true;
        skinspec.y=800;
   points -= pricespeskin;
   Pointsvalue.text = "points: " + points;
   specskinbuyed = true;
   areyousurewanttobuyskinspec = false;
   println("plr buy special skin!");
} else if (points <= pricespeskin && (mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinspec == true)) {
    notenoughmoney = true;
   println("plr dont have enough money to buy this skin!");
} else if ((mouseButton == LEFT) && (mouseX >= nobuttonbuyskin.x && mouseX <= nobuttonbuyskin.x + nobuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= nobuttonbuyskin.y + nobuttonbuyskin.height && areyousurewanttobuyskinspec == true)) {
    areyousurewanttobuyskinspec = false;
   println("plr dont want to buy this skin *cry*");
}
//skinpink
if ((mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinpink == true && points >= pricepinkskin)) {
       skinpink.x=178;
      skinpink.y=800;
         pinkskinbuy1 = true;
   points -= pricepinkskin;
   Pointsvalue.text = "points: " + points;
   pinkskinbuyed = true;
   areyousurewanttobuyskinpink = false;
   println("plr buy pink skin!");
} else if (points <= pricepinkskin && (mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x &&
 mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height &&
      areyousurewanttobuyskinpink == true)) {
    notenoughmoney = true;
   println("plr dont have enough money to buy this skin!");
} else if ((mouseButton == LEFT) && (mouseX >= nobuttonbuyskin.x && mouseX <= nobuttonbuyskin.x + nobuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= nobuttonbuyskin.y + nobuttonbuyskin.height && areyousurewanttobuyskinpink == true)) {
    areyousurewanttobuyskinpink = false;
   println("plr dont want to buy this skin *cry*");
}
//skinrainbow
if ((mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinrainbow == true && points >= pricerainbowskin)) {
  skinrainbow.x=540;
  skinrainbow.y=800;
   points -= pricerainbowskin;
      rainbowskinbuy1 = true;
   Pointsvalue.text = "points: " + points;
   rainbowskinbuyed = true;
   areyousurewanttobuyskinrainbow = false;
   println("plr buy rainbow skin!");
} else if (points <= pricerainbowskin && (mouseButton == LEFT) && (mouseX >= yesbuttonbuyskin.x && mouseX <= yesbuttonbuyskin.x + yesbuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= yesbuttonbuyskin.y + yesbuttonbuyskin.height && areyousurewanttobuyskinrainbow == true)) {
    notenoughmoney = true;
   println("plr dont have enough money to buy this skin!");
} else if ((mouseButton == LEFT) && (mouseX >= nobuttonbuyskin.x && mouseX <= nobuttonbuyskin.x + nobuttonbuyskin.width &&
     mouseY >= yesbuttonbuyskin.y && mouseY <= nobuttonbuyskin.y + nobuttonbuyskin.height && areyousurewanttobuyskinrainbow == true)) {
    areyousurewanttobuyskinrainbow = false;
   println("plr dont want to buy this skin *cry*");
}

     if ((mouseButton == LEFT) && (mouseX >= skindef.x && mouseX <= skindef.x + skindef.width &&
    mouseY >= skindef.y && mouseY <= skindef.y + skindef.height)) {
      
    }


    //eqpp and equipped skins
    if (defon == true && defequip == false) {
    eqpp.draw();
    }
      if (redon == true && redequip == false) {
    eqpp.draw();
    }
     if (blueon == true && blueequip == false) {
    eqpp.draw();
    }
    if (pinkon == true && pinkequip == false) {
    eqpp.draw();
    }
    if (rainbowon == true && rainequip == false) {
    eqpp.draw();
    }
    if (specialon2 == true && goldequip == false) {
    eqpp.draw();
    }

     if (defon == true && defequip == true) {
    equipped.draw();
    }
    if (redon == true && redequip == true) {
    equipped.draw();
    }
     if (blueon == true && blueequip == true) {
    equipped.draw();
    }
    if (pinkon == true && pinkequip == true) {
    equipped.draw();
    }
    if (rainbowon == true && rainequip == true) {
    equipped.draw();
    }
    if (specialon2 == true && goldequip == true) {
    equipped.draw();
    }
    //redequip = true;
  //  blueequip = false;
   // pinkequip = false;
   // rainequip  = false;
   // blueequip = false;
   // goldequip = false;
  if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
     mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && defon == true && defequip == false)){
      defequip = true;
      pinkequip = false;
      blueequip = false;
      rainequip = false;
      goldequip = false;
      redequip = false;
     }
  if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
     mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && redon == true && redequip == false)){
      defequip = false;
      pinkequip = false;
      blueequip = false;
      rainequip = false;
      goldequip = false;
      redequip = true;
     }
       if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
     mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && blueon == true && blueequip == false)){
      defequip = false;
      pinkequip = false;
      blueequip = true;
      rainequip = false;
      goldequip = false;
      redequip = false;
     }
       if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
     mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && pinkon == true && pinkequip == false)){
      defequip = false;
      pinkequip = true;
      blueequip = false;
      rainequip = false;
      goldequip = false;
      redequip = false;
     }
       if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
     mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && rainbowon == true && rainequip == false)){
      defequip = false;
      pinkequip = false;
      blueequip = false;
      rainequip = true;
      goldequip = false;
      redequip = false;
     }
       if ((mouseButton == LEFT) && (mouseX >= eqpp.x && mouseX <= eqpp.x + eqpp.width &&
     mouseY >= eqpp.y && mouseY <= eqpp.y + eqpp.height && specialon == true && goldequip == false)){
      defequip = false;
      pinkequip = false;
      blueequip = false;
      rainequip = false;
      goldequip = true;
      redequip = false;
     }

if (notenoughmoney == true){
   blockblackscreenbyskin.draw();
   framenotenoughmoney.draw();
   closenotmoney.draw();
   areyousurewanttobuyskinred = false;
}
    //plr buy skin!
    if (redskinbuyed == true){
      buyredskin.x=2500;
      lockred = false;
      skinred.draw();
    }
    if (blueskinbuyed == true){
      buyblueskin.x=2500;
      lockblue = false;
      skinblue.draw();
    }
    if (pinkskinbuyed == true){
      buypinkskin.x=2500;
      lockpink = false;
      skinpink.draw();
    }
    if (rainbowskinbuyed == true){
      buyrainbowskin.x=2500;
      lockrain = false;
      skinrainbow.draw();
    }
    if (specskinbuyed == true){
      buyspaceilskin.x=2500;
      lockspecial = false;
       skinspec.draw();
    }
    
      if (areyousurewanttobuyskinred == true){
           blockblackscreenbyskin.draw();
           redskinareyousure.draw();
           yesbuttonbuyskin.draw();
           nobuttonbuyskin.draw();
  }
   if (areyousurewanttobuyskinblue == true){
           blockblackscreenbyskin.draw();
           blueskinareyousure.draw();
           yesbuttonbuyskin.draw();
           nobuttonbuyskin.draw();
  }
   if (areyousurewanttobuyskinpink == true){
           blockblackscreenbyskin.draw();
           pinkskinareyousure.draw();
           yesbuttonbuyskin.draw();
           nobuttonbuyskin.draw();
  }
   if (areyousurewanttobuyskinrainbow == true){
           blockblackscreenbyskin.draw();
           rainbowskinareyousure.draw();
           yesbuttonbuyskin.draw();
           nobuttonbuyskin.draw();
  }
   if (areyousurewanttobuyskinspec == true){
           blockblackscreenbyskin.draw();
           spacielskinareyousure.draw();
           yesbuttonbuyskin.draw();
           nobuttonbuyskin.draw();
  }
    
  
 if((mouseButton == LEFT) && (mouseX >= closenotmoney.x && mouseX <= closenotmoney.x + closenotmoney.width &&
     mouseY >= closenotmoney.y && mouseY <= closenotmoney.y + closenotmoney.height)){
       notenoughmoney = false;
       areyousurewanttobuyskinblue = false;
       areyousurewanttobuyskinred = false;
       areyousurewanttobuyskinpink = false;
       areyousurewanttobuyskinrainbow = false;
       areyousurewanttobuyskinspec = false;

     }

   //change x
      Exitbutton.x= 2500;
      buttonplay1.x=2500;
            buttonplay2.x=2500;
      texthelp.x=2500;
      Exitbutton.y=2000;
      Exitbutton.draw();
      skinspaperbutton.x=2500;
      imgpngsettingsicon.x=2500;
      skinspaperbutton.y=2500;
      skinspaperbutton.draw();
        informationbutton.x=2500;
          buttontutorialpng.x=2500;
          buttontutorialpng.y=2000;
          informationbutton.y=2000;
          informationbutton.draw();
          buttontutorialpng.draw();}
   else {
      imgpngsettingsicon.x=1100; 
 }
   //buttonplay
  if (mouseX >= buttonplay1.x && mouseX <= buttonplay1.x + buttonplay1.width &&
     mouseY >= buttonplay1.y && mouseY <= buttonplay1.y + buttonplay1.height && skinsframeopen == false) {
    buttonplay1.y=240;
    buttonplay1.draw();
  } else {
    buttonplay1.y=230;
    buttonplay1.draw();
  }
 //settingsicon
  if (mouseX >= imgpngsettingsicon.x && mouseX <= imgpngsettingsicon.x + imgpngsettingsicon.width &&
     mouseY >= imgpngsettingsicon.y && mouseY <= imgpngsettingsicon.y + imgpngsettingsicon.height) {
    if (clickedSettings == true) {
      imgpngsettingsicon2.draw();
    } else if (clickedSettings == false) {
      imgpngsettingsicon3.draw();
    }
  } else {
    imgpngsettingsicon.draw();
  }
        //move block all imageopened..number!
    if (imageOpened3 || imageOpened2 || imageOpened ||  movelevels == true || safrsdfh == true || skinsframeopen == true){
      Exitbutton.x= 2500;
      Exitbutton.y=2000;
      Exitbutton.draw();
      skinspaperbutton.x=2500;
      skinspaperbutton.y=2500;
      skinspaperbutton.draw();
  }
     else {
       Exitbutton.x=500;
       Exitbutton.y=925;
       Exitbutton.draw();
      skinspaperbutton.x=1070;
      skinspaperbutton.y=900;
      skinspaperbutton.draw(); 
    }
if (asd == false || start == true || start2 == true || start3 == true || start4 == true || 
 start5 == true || start6 == true || start7 == true || start8 == true || start9 == true || start10 == true) {
  level1.x = 2500;
  level2.x = 2500;
  level3.x = 2500;
  level4.x = 2500;
  level5.x = 2500;
  level6.x = 2500;
  level7.x = 2500;
  level8.x = 2500;
  level9.x = 2500;
  level10.x = 2500;
} else if (asd == true || start == false || start2 == false || start3 == false || start4 == false || 
 start5 == false || start6 == false || start7 == false || start8 == false || start9 == false || start10 == false) {
  level1.x = 240;
  level1.y = 235;
  level2.x = 530;
  level2.y = 235;
  level3.x = 820;
  level3.y = 235;
  level4.x = 1110;
  level4.y = 235;
  level5.x = 1400;
  level5.y = 235;
  //row 2
  level6.x = 240;
  level6.y = 570;
  level7.x = 530;
  level7.y = 570;
  level8.x = 820;
  level8.y = 570;
  level9.x = 1110;
  level9.y = 570;
  level10.x = 1400;
  level10.y = 570;
}

        if (imageOpened3 || imageOpened2 || !imageOpened){
          informationbutton.x=2500;
          buttontutorialpng.x=2500;
          buttontutorialpng.y=2000;
          informationbutton.y=2000;
          informationbutton.draw();
          buttontutorialpng.draw();
        }
     else {
    informationbutton.x=900;
    informationbutton.y=850;
    buttontutorialpng.x=120;
    buttontutorialpng.y=850;
    informationbutton.draw();
    buttontutorialpng.draw();
    }
    if (gamesstartboolean2 && gamestart == false) {
      texthelp.x=10;
    }
   if (!gamesstartboolean2 && gamestart == true){
     texthelp.x=2500;
   }
    
    // Close game!
    if (mouseX >= Exitbutton.x && mouseX <= Exitbutton.x + Exitbutton.width &&
      mouseY >= Exitbutton.y && mouseY <= Exitbutton.y + Exitbutton.height) {
    if (clickedSettings == true) {
      Exitbutton.draw();
      Exitbutton.rotation = 5;
  } else { 
    Exitbutton.draw();
    Exitbutton.rotation = -5;
  }
  
}   else {
      // If the mouse is not touch the button rotation = 0!!
     Exitbutton.rotation = 0;
     Exitbutton.draw();
}

   if (mouseX >= skinspaperbutton.x && mouseX <= skinspaperbutton.x + skinspaperbutton.width &&
      mouseY >= skinspaperbutton.y && mouseY <= skinspaperbutton.y + skinspaperbutton.height) {
    if (clickedSettings == true) {
      skinspaperbutton.draw();
      skinspaperbutton.rotation = 5;
  } else { 
    skinspaperbutton.draw();
    skinspaperbutton.rotation = -5;
  }
  
}   else {
      // If the mouse is not touch the button rotation = 0!!
     skinspaperbutton.rotation = 0;
     skinspaperbutton.draw();
}


//onblackscreenopenedtrue
      if (blacscreenopened) {
       Blackscreen.draw();
       Nobutton.draw();
       Yesbutton.draw();
}
     //exit of the game
    if ((!blacscreenopened && (mouseButton == LEFT) && (mouseX >= Exitbutton.x && mouseX <= Exitbutton.x + Exitbutton.width &&
     mouseY >= Exitbutton.y && mouseY <= Exitbutton.y + Exitbutton.height) && (mouseX >= Exitbutton.x && mouseX <= Exitbutton.x + Exitbutton.width &&
     mouseY >= Exitbutton.y && mouseY <= Exitbutton.y + Exitbutton.height))) {
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
      // blacscreenopened = true;
    //  if ((mouseButton == LEFT) && (mouseX >= Yesbutton.x && mouseX <= Yesbutton.x + Yesbutton.width &&
     //mouseY >= Yesbutton.y && mouseY <= Yesbutton.y + Yesbutton.height)) {
         print("The plr exit of the game!");
        String[] data = loadStrings("savedata.txt");
       points = int(data[0]);
       println("The loaded data is: " + points); 
      delay(2500);
       exit();
     //  else if ((mouseButton == LEFT) && (mouseX >= Nobutton.x && mouseX <= Nobutton.x + Nobutton.width &&
    // mouseY >= Nobutton.y && mouseY <= Nobutton.y + Nobutton.height)) {
      // blacscreenopened = false;
}
  

   //openframesttings * its need be at the end of the code!!!!!!!!*
while (imageOpened) {
    buttonplay1.x=2500;
    block.draw();
    settingsframeimg.draw();
    if(musicofforon == true && zajbndss){
    offmusic.x = 2500;
    onmusic.x=685;
    chackmusicoffon.draw();
        onmusic.draw();
  }
  if(musicofforon == false && !zajbndss){
    offmusic.x = 685;
    onmusic.x=2500;
        chackmusicoffon.draw();
            offmusic.draw();
  }
 if ((mouseButton == LEFT) && (mouseX >= onmusic.x && mouseX <= onmusic.x + onmusic.width &&
    mouseY >= onmusic.y && mouseY <= onmusic.y + onmusic.height)&& zajbndss == false) {
              //chackmusicoffon.draw();
              zajbndss = true;
      //print("false");
      musicofforon = false;
 }
  if ((mouseButton == LEFT) && (mouseX >= offmusic.x && mouseX <= offmusic.x + offmusic.width &&
    mouseY >= offmusic.y && mouseY <= offmusic.y + offmusic.height)&& zajbndss == true) {
           //   chackmusicoffon.draw();
           zajbndss =false;
     // print("true");
      musicofforon = true;
 }

    closebutton.draw();
    Xclosetext.draw();
    buttontutorialpng.draw();
    informationbutton.draw();
            chackmusicoffon.draw();
       break;
     }
     if (!imageOpened){
     buttonplay1.x=270;
}

     if (!imageOpened && (mouseButton == LEFT) && (mouseX >= imgpngsettingsicon.x && mouseX <= imgpngsettingsicon.x + imgpngsettingsicon.width &&
     mouseY >= imgpngsettingsicon.y && mouseY <= imgpngsettingsicon.y + imgpngsettingsicon.height)) {
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
    imageOpened = true;
    }
    if (!imageOpened) {
      //print("frame settings not visibale!");
    }
    //framesettingsclose
    if (imageOpened && (mouseButton == LEFT) && (mouseX >= closebutton.x && mouseX <= closebutton.x + closebutton.width &&
     mouseY >= closebutton.y && mouseY <= closebutton.y + closebutton.height) && (mouseX >= Xclosetext.x && mouseX <= Xclosetext.x + Xclosetext.width &&
     mouseY >= Xclosetext.y && mouseY <= Xclosetext.y + Xclosetext.height)) {
       buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
    imageOpened = false;
    }
    
    //loadingscreenframe
  while (startthegame == true){
   intro.draw();
   Loadingscreen.draw();
   Messege.draw();
   IntroBlock.draw();
   delay(150); //-- normal speed 150 fast 50
   break;}
    while (widthx <= 1175){
     widthx = widthx + 40;
     IntroBlock.width = widthx;
     IntroBlock.draw();
     percentageloadingscreen.draw();
     //print(IntroBlock.width);
     widthblock300 = true;
     percentageloadingscreen.draw();
     //print("number:"+IntroBlock.width);
     if (widthx == 1200){
       startthegame = false;
     }
     break;
    }
    while (widthblock300 == true){
    percentageloadingscreen.draw();
    break;
    }
 
    while (percentageloadingscreenint < 100){
      percentageloadingscreenint = percentageloadingscreenint + 4;
      percentageloadingscreen.text=percentageloadingscreenint+ "%";
      break;
    }

    if (IntroBlock.width >=1175){
      startthegame = false;
      widthblock300 = false;
    }
        //play the game!!(exit of lobby game!)
     while (!imageOpened3 && !imageOpened2 && startthegame == false && (mouseButton == LEFT) && (mouseX >= buttonplay1.x && mouseX <= buttonplay1.x + buttonplay1.width &&
     mouseY >= buttonplay1.y && mouseY <= buttonplay1.y + buttonplay1.height && skinsframeopen == false && sdhsd == false)) {
       sdhsd = true;
       buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
     //delay(1000);
     starttherealgame = false;
     //print("close");
     break;
}
   while (starttherealgame == false){
     Loading.draw();
     Loadingblockgame.draw();
     skinspaperbutton.x=2500;
     delay(0); //--250normalspeed starttherealgame
     break;}
     while (widthx2 <= 1270 && starttherealgame == false){
       delay(0);
       widthx2 = widthx2 + 42; //--speed block! dont tuch
       Loadingblockgame.width = widthx2;
       Loadingblockgame.draw();
       //percentageloadingscreen.draw();
       widthblock3002 = true;
     while (percentageloadingscreenint2 < 100 && widthx2 <= 1270){
      percentageloadingscreenint2 = percentageloadingscreenint2 + int(random(3,4));
      percentageloadingscreen2.text=percentageloadingscreenint2+ "%";
      percentageloadingscreen2.draw();
     // print(percentageloadingscreenint2);
      break;
    }
       break;
     }
   // while (widthblock3002 == true){
   //percentageloadingscreen2.draw();
  // break;
  //}
    if (Loadingblockgame.width >=1270 && dsfg == false){
      widthblock3002 = false;
      endlaodingscreenrealgame = true;
    }
    //move
    if (dsfg == false && start8 == true || start == true || start2 == true || start3 == true || start4 == true || 
    start5 == true || start6 == true || start7 == true || start9 == true || start10 == true){
      dsfg = true;
            endlaodingscreenrealgame = false;
    }
        if (Loadingblockgame.width >=1270){
          delay(50);
          asd=true;
    }
          //level select frame
    if (endlaodingscreenrealgame == true){
      lobbymusiconoroff = false;
      selectlevel = true;
      movelevels = true;
      levelselect.x=0;
      level1.x=240;
      level2.x=530;
      level3.x=820;
      level4.x=1110;
      level5.x=1400;
      level6.x=240;
      level7.x=530;
      //Exitbutton.x=800;
      level8.x=820;
      level9.x=1110;
      level10.x=1400;
      levelselect.draw();
      level1.draw();
      level2.draw();
      level3.draw();
      level4.draw();
      level5.draw();
      level6.draw();
      level7.draw();
      level8.draw();
      level9.draw();
      level10.draw();
      Exitbutton.x=2500;
    }
       //ifs level select frame
    //level1
    if ((mouseButton == LEFT) && (mouseX >= level1.x && mouseX <= level1.x + level1.width &&
     mouseY >= level1.y && mouseY <= level1.y + level1.height)) {
       buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
       gamesstartboolean2=true;
      movelevels=true;
      levelselect1 = true;
      endlaodingscreenrealgame = false;
      start = true;
 }
   //level2
      if ((mouseButton == LEFT) && (mouseX >= level2.x && mouseX <= level2.x + level2.width &&
     mouseY >= level2.y && mouseY <= level2.y + level2.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
      movelevels=true;
      levelselect2 = true;
      endlaodingscreenrealgame = false;
      start2 = true;
            

 }
     if ((mouseButton == LEFT) && (mouseX >= level3.x && mouseX <= level3.x + level3.width &&
     mouseY >= level3.y && mouseY <= level3.y + level3.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
      movelevels = true;
      levelselect3 = true;
      endlaodingscreenrealgame = false;
       start3 = true;
     }
     if ((mouseButton == LEFT) && (mouseX >= level4.x && mouseX <= level4.x + level4.width &&
     mouseY >= level4.y && mouseY <= level4.y + level4.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
      movelevels=true;
      levelselect4 = true;
      endlaodingscreenrealgame = false;
       start4 = true;
 }
     if ((mouseButton == LEFT) && (mouseX >= level5.x && mouseX <= level5.x + level5.width &&
     mouseY >= level5.y && mouseY <= level5.y + level5.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
      movelevels=true;
      levelselect5 = true;
      endlaodingscreenrealgame = false;
      start5 = true;
 }
     if ((mouseButton == LEFT) && (mouseX >= level6.x && mouseX <= level6.x + level6.width &&
     mouseY >= level6.y && mouseY <= level6.y + level6.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
              movelevels=true;

      levelselect6 = true;
            endlaodingscreenrealgame = false;
                  start6 = true;
 }
     if ((mouseButton == LEFT) && (mouseX >= level7.x && mouseX <= level7.x + level7.width &&
     mouseY >= level7.y && mouseY <= level7.y + level7.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
              movelevels=true;
      levelselect7 = true;
            endlaodingscreenrealgame = false;
                  start7 = true;
 }
     if ((mouseButton == LEFT) && (mouseX >= level8.x && mouseX <= level8.x + level8.width &&
     mouseY >= level8.y && mouseY <= level8.y + level8.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
              movelevels=true;
      levelselect8 = true;
            endlaodingscreenrealgame = false;
                  start8 = true;
 }
     if ((mouseButton == LEFT) && (mouseX >= level9.x && mouseX <= level9.x + level9.width &&
     mouseY >= level9.y && mouseY <= level9.y + level9.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
              movelevels=true;
      levelselect9 = true;
            endlaodingscreenrealgame = false;
                  start9 = true;
 }
     if ((mouseButton == LEFT) && (mouseX >= level10.x && mouseX <= level10.x + level10.width &&
     mouseY >= level10.y && mouseY <= level10.y + level10.height)) {
              gamesstartboolean2=true;
  buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
       movelevels=true;
      levelselect10 = true;
       endlaodingscreenrealgame = false;
             start10 = true;
 }
 //if start
 while (start == true && start2 == false && start3 == false && start4 == false && 
 start5 == false && start6 == false && start7 == false && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
   lol.draw();
    Trash.draw();
    jsadhjbsadws = true;
    lobbymusic = false;
   texthelp.draw();
   exittolobby.draw();
   achpngicon.x=1600;
   achpngicon.y=20;
   achpngicon.draw();
   while (textplay1.y <= -100){
     delay(70);
     textplay1.y += 30;
     textplay1.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay1.draw();
    break;
}

 while (start == false && start2 == true && start3 == false && start4 == false && 
 start5 == false && start6 == false && start7 == false && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
      achpngicon.x=1600;
      jsadhjbsadws = true;
   achpngicon.y=20;
      lol.draw();
   achpngicon.draw();
      Trash.draw();
   texthelp.draw();
   exittolobby.draw();
   while (textplay2.y <= -100){
     delay(70);
     textplay2.y += 30;
     textplay2.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay2.draw();
    break;
}
 while (start == false && start2 == false && start3 == true && start4 == false && 
 start5 == false && start6 == false && start7 == false && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
      lol.draw();
      jsadhjbsadws = true;
         achpngicon.x=1600;
   achpngicon.y=20;
   achpngicon.draw();

      Trash.draw();
   texthelp.draw();
   exittolobby.draw();
  while (textplay3.y <= -100){
     delay(70);
     textplay3.y += 30;
     textplay3.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay3.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == true && 
 start5 == false && start6 == false && start7 == false && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
   achpngicon.draw();
   //sadkjhsahd
   sakjdhsiauhdfdstfnm = true;
      Trash.draw();
   texthelp.draw();
   exittolobby.draw();
  while (textplay4.y <= -100){
     delay(70);
     textplay4.y += 30;
     textplay4.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay4.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == false && 
 start5 == true && start6 == false && start7 == false && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
   achpngicon.draw();
sakjdhsiauhdfdstfnm = true;
      Trash.draw();
   texthelp.draw();
   exittolobby.draw();
   while (textplay5.y <= -100){
     delay(70);
     textplay5.y += 30;
     textplay5.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay5.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == false && 
 start5 == false && start6 == true && start7 == false && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
   achpngicon.draw();
sakjdhsiauhdfdstfnm = true;
      Trash.draw();
   texthelp.draw();
   exittolobby.draw();
  while (textplay6.y <= -100){
     delay(70);
     textplay6.y += 30;
     textplay6.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay6.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == false && 
 start5 == false && start6 == false && start7 == true && start8 == false && start9 == false && start10 == false){
   officebackground1.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
      sadjhsd = true;
   achpngicon.draw();
      Trash.draw();
   texthelp.draw();
   exittolobby.draw();
  while (textplay7.y <= -100){
     delay(70);
     textplay7.y += 30;
     textplay7.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay7.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == false && 
 start5 == false && start6 == false && start7 == false && start8 == true && start9 == false && start10 == false){
   officebackground2.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
   achpngicon.draw();
      sadjhsd = true;

   Trash.draw();
   texthelp.draw();
   exittolobby.draw();
   while (textplay8.y <= -100){
     delay(70);
     textplay8.y += 30;
     textplay8.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay8.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == false && 
 start5 == false && start6 == false && start7 == false && start8 == false && start9 == true && start10 == false){
   officebackground2.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
   achpngicon.draw();
      sadjhsd = true;
   Trash.draw();
   texthelp.draw();
   exittolobby.draw();
     while (textplay9.y <= -100){
     delay(70);
     textplay9.y += 30;
     textplay9.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay9.draw();
    break;
}
 while (start == false && start2 == false && start3 == false && start4 == false && 
 start5 == false && start6 == false && start7 == false && start8 == false && start9 == false && start10 == true){
   officebackground2.draw();
      achpngicon.x=1600;
   achpngicon.y=20;
      lol.draw();
      Trash.draw();
   texthelp.draw();
   hsdhef = true;
      achpngicon.draw();
   exittolobby.draw();
      while (textplay10.y <= -100){
     delay(70);
     textplay10.y += 30;
     textplay10.draw();
     //print("dsad"+textplay1.y);
     break;}
    textplay10.draw();
    break;
}
    if ((mouseButton == LEFT) && (mouseX >= texthelp.x && mouseX <= texthelp.x + texthelp.width &&
     mouseY >= texthelp.y && mouseY <= texthelp.y + texthelp.height)) {
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();

       texthelp3 = true;
     }
     while(texthelp3 == true){
       blacblock.draw();
       helpframe.draw();
       closebuttonframehelp.draw();
       break;
     }
        if ((mouseButton == LEFT) && (mouseX >= closebuttonframehelp.x && mouseX <= closebuttonframehelp.x + closebuttonframehelp.width &&
     mouseY >= closebuttonframehelp.y && mouseY <= closebuttonframehelp.y + closebuttonframehelp.height)){
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
       texthelp3 = false;
     }
           if ((mouseButton == LEFT) && (mouseX >= exittolobby.x && mouseX <= exittolobby.x + exittolobby.width &&
     mouseY >= exittolobby.y && mouseY <= exittolobby.y + exittolobby.height)) {
       imageOpened = true;
       endlaodingscreenrealgame = false;
       start = false;
       start2 = false;
       start3 = false;
       start4 = false;
       start5 = false;
       start6 = false;
       start7 = false;
       start8 = false;
       start9 = false; 
       start10 = false;
       print("plr exit of the game ");
       String[] data = loadStrings("savedata.txt");
       points = int(data[0]);
       println("The loaded data is: " + points); 
       exit();
 }
 //achframe
 if ((mouseButton == LEFT) && (mouseX >= achpngicon.x && mouseX <= achpngicon.x + achpngicon.width &&
     mouseY >= achpngicon.y && mouseY <= achpngicon.y + achpngicon.height)){
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
       achframe = true;
   }
while (achframe == true){
  gamestart = false;
  Achframe.draw();
 if(dsfhdsf == false){
  achfirstpaper.draw();
  sdhsddf.draw();
}
if(dsfhdsf == true){
  achfirstpaper.draw();
}
if(redskinbuyedach == false){
  achredskinbuyed.draw();
  achredskinbuyedlock.draw();
}
if(redskinbuyedach == true){
  achredskinbuyed.draw();
}
if(blueskinbuy1 == false){
  blueskinbuy.draw();
  lock3.draw();
}
if(pinkskinbuy1 == false){
  pinkskinbuy.draw();
  lock4.draw();
}
if(rainbowskinbuy1 == false){
  rainbowskinbuy.draw();
  lock5.draw();
}
if(goldskinbuy1 == false){
  goldbuyskin.draw();
  lock6.draw();
}

if(blueskinbuy1 == true){
  blueskinbuy.draw();
}
if(pinkskinbuy1 == true){
  pinkskinbuy.draw();
}
if(rainbowskinbuy1 == true){
  rainbowskinbuy.draw();
}
if(goldskinbuy1 == true){
  goldbuyskin.draw();
}
  
    exitbuttonframeach.draw();
  break;
}
 if ((mouseButton == LEFT) && (mouseX >= exitbuttonframeach.x && mouseX <= exitbuttonframeach.x + exitbuttonframeach.width &&
     mouseY >= exitbuttonframeach.y && mouseY <= exitbuttonframeach.y + exitbuttonframeach.height) && gamestart == true){
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
    achframe = false;
     gamestart = true;
   }
    if ((mouseButton == LEFT) && (mouseX >= exitbuttonframeach.x && mouseX <= exitbuttonframeach.x + exitbuttonframeach.width &&
     mouseY >= exitbuttonframeach.y && mouseY <= exitbuttonframeach.y + exitbuttonframeach.height) && gamestart == false){
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
    achframe = false;
     gamestart = false;
   }
 //gamestart
  while (gamestart == true && start == true && redequip == true){
    delay(0);
    while(sdhsdsd == true){
    defequip = false;
    paper.x = 2500;
    paper.y = -1000;
    break;
  }
    closegame23.draw();
    Points.draw();
    numbergetedpapers.draw();
    timelevel1 = 25;
    redskinpaper.y+=10;
    redskinpaper.draw();
    lol.draw();
    Trash.draw();
    // print("sad");
    break;
}
while (jjjj == 1) {
        while (gamestart){
        Points.text = "Points: " + points;
        Points.draw();
        numbergetedpapers.text = "Paper: " + numbergetedpapers1;
        numbergetedpapers.draw();
        break;
        }
    while (paperinshape == true) {
        points += 1;
        numbergetedpapers1 += 1;
        nnnn = true;
        System.out.println("+1 point");
        String[] data = new String[1];
        data[0] = str(points);
        saveStrings("savedata.txt", data);
        paperinshape = false;
        break;
    }
    break;
}
while (firstpaper1){
    sadsad.draw();
    dsfhdsf = true;
    while(sadsad.y >= 800 && !dsiofjhds){
      //print(sadsad.y);
      sadsad.y -= 25;
      break;
    }
    if(sadsad.y == 800){
      sdfdsffdg = true;
      dsiofjhds = true;
    }
     while(sdfdsffdg && djsd <= 135){
       djsd += 1;
       break;
     }
      while(sadsad.y <= 4000 && djsd == 135){
        sadsad.y = 4000;
        bookach = true;
        break;
  }
    break;
}

  //level 1 def skin
  while (gamestart == true && start == true && defequip == true && pinkequip == false){
    delay(0);
    closegame23.draw();
    Points.draw();
    numbergetedpapers.draw();
    //timelevel1 = 25;
    //paper.y+=10;
    while (timelevel1 <= 25){
      timelevel1 -= 1;
      paper.y+=10;
      paper.draw();
  if (Trash.pointInShape(paper.x,paper.y)) {
  paper.x=int(random(10,1850));
  Papercach.loop = false;
  Papercach.load("Papercach.mp3");
  Papercach.play();
  paper.y=-20;
 firstpaper1 = true;
 // points += 1;
  paperinshape = true;
  //numbergetedpapers1 += 1;
  Points.text = "Points: " + points;
  Points.draw();
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  numbergetedpapers.draw();
  paper.draw();
  println("+1 point");
}
break;
    }
    lol.draw();
    Trash.draw();
    // print("sad");
    break;
}
//ifs agin!
  if(Trash.pointInShape(paper.x,paper.y)) {
    firstpaper1 = true;
}
  if (Trash.pointInShape(redskinpaper.x,redskinpaper.y)) {
    firstpaper1 = true;
  }
   if (Trash.pointInShape(blueskinpaper.x,blueskinpaper.y)) {
    firstpaper1 = true;
  }
   if (Trash.pointInShape(pinkskinpaper.x,pinkskinpaper.y)) {
    firstpaper1 = true;
  }
   if (Trash.pointInShape(rainbowskinpaper.x,rainbowskinpaper.y)) {
    firstpaper1 = true;
  }
   if (Trash.pointInShape(specialskinpaper.x,specialskinpaper.y)) {
    firstpaper1 = true;
  }

  while (gamestart == true && start == true && pinkequip == true){
    delay(0);
    while(sdhsdsd == true){
    defequip = false;
    paper.x = 2500;
    paper.y = -1000;
  }
    closegame23.draw();
    Points.draw();
    numbergetedpapers.draw();
    timelevel1 = 25;
    pinkskinpaper.y+=10;
    pinkskinpaper.draw();
    lol.draw();
    Trash.draw();
    // print("sad");
    break;
}
  while (gamestart == true && start == true && blueequip == true){
    delay(0);
    closegame23.draw();
    Points.draw();
    numbergetedpapers.draw();
    timelevel1 = 25;
    blueskinpaper.y+=10;
    blueskinpaper.draw();
    lol.draw();
    Trash.draw();
    // print("sad");
    break;
}
  while (gamestart == true && start == true && rainequip == true){
    delay(0);
    closegame23.draw();
    Points.draw();
    numbergetedpapers.draw();
    timelevel1 = 25;
    rainbowskinpaper.y+=10;
    rainbowskinpaper.draw();
    lol.draw();
    Trash.draw();
    // print("sad");
    break;
}
 if (gamestart)
  while (gamestart == true && start == true && goldequip == true){
    delay(0);
    closegame23.draw();
    Points.draw();
    numbergetedpapers.draw();
    timelevel1 = 25;
    specialskinpaper.y+=10;
    specialskinpaper.draw();
    lol.draw();
    Trash.draw();
    // print("sad");
    break;
}
      if ((mouseButton == LEFT) && (mouseX >= closegame23.x && mouseX <= closegame23.x + closegame23.width &&
     mouseY >= closegame23.y && mouseY <= closegame23.y + closegame23.height)){
            buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
      delay(500);
      print("plr exit of the game!");
       String[] data = loadStrings("savedata.txt");
       points = int(data[0]);
       println("The loaded data is: " + points); 
      exit();
     }
while(true){
if (Trash.pointInShape(redskinpaper.x,redskinpaper.y)) {
  redskinpaper.x=int(random(10,1600));
  redskinpaper.y=-20;
 // points += 1;
    paperinshape = true;
        firstpaper1 = true;


  //numbergetedpapers1 += 1;
  Points.text = "Points: " + points;
  Points.draw();
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  numbergetedpapers.draw();
  redskinpaper.draw();
  println("+1 point");
}


if (Trash.pointInShape(blueskinpaper.x,blueskinpaper.y)) {
  blueskinpaper.x=int(random(10,1600));
  blueskinpaper.y=-20;
  //points += 1;
  //numbergetedpapers1 += 1;
    paperinshape = true;
        firstpaper1 = true;


  Points.text = "Points: " + points;
  Points.draw();
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  numbergetedpapers.draw();
  blueskinpaper.draw();
  println("+1 point");

}
if (Trash.pointInShape(pinkskinpaper.x,pinkskinpaper.y)) {
  pinkskinpaper.x=int(random(10,1600));
  pinkskinpaper.y=-20;
 // points += 1;
  //numbergetedpapers1 += 1;
  Points.text = "Points: " + points;
  Points.draw();
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  numbergetedpapers.draw();
    paperinshape = true;
        firstpaper1 = true;


  pinkskinpaper.draw();
  println("+1 point");

}
if (Trash.pointInShape(rainbowskinpaper.x,rainbowskinpaper.y)) {
  rainbowskinpaper.x=int(random(10,1600));
  rainbowskinpaper.y=-20;
  //points += 1;
    paperinshape = true;
        firstpaper1 = true;


  //numbergetedpapers1 += 1;
  Points.text = "Points: " + points;
  Points.draw();
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  numbergetedpapers.draw();
  rainbowskinpaper.draw();
  println("+1 point");

}
if (Trash.pointInShape(specialskinpaper.x,specialskinpaper.y)) {
  specialskinpaper.x=int(random(10,1600));
  specialskinpaper.y=-20;
    paperinshape = true;
        firstpaper1 = true;


 // points += 1;
  //numbergetedpapers1 += 1;
  Points.text = "Points: " + points;
  Points.draw();
  numbergetedpapers.text = "Paper: " +numbergetedpapers1;
  numbergetedpapers.draw();
  specialskinpaper.draw();
  println("+1 point");
}

if(blockindactorpapertouch.pointInShape(paper.x,paper.y) && achframe == false){
  paper.x=int(random(40,1600));
  paper.y=-20;
  //paperinshape = true;
  lifes -= 1;
  paper.draw();
  print("-1 life!");
}
if(blockindactorpapertouch.pointInShape(paper.x,paper.y) || Trash.pointInShape(paper.x,paper.y) && achframe == false){
  paper.x=randomx;
  paper.y=-20;
  asddf = true;
}
while(asddf == true){
  //print("true");
  paper.y+=speeddownpaperlevel1;
  paper.x=randomx;
}
if(blockindactorpapertouch.pointInShape(redskinpaper.x,redskinpaper.y) && achframe == false){
  redskinpaper.x=int(random(40,1600));
  redskinpaper.y=-20;
   // paperinshape = true;

  lifes -= 1;
  redskinpaper.draw();
  print("-1 life!");
}
if(blockindactorpapertouch.pointInShape(blueskinpaper.x,blueskinpaper.y) && achframe == false){
  blueskinpaper.x=int(random(40,1600));
  blueskinpaper.y=-20;
    //paperinshape = true;

  lifes -= 1;
  blueskinpaper.draw();
  print("-1 life!");
}

if(blockindactorpapertouch.pointInShape(pinkskinpaper.x,pinkskinpaper.y)&& achframe == false){
  pinkskinpaper.x=int(random(40,1600));
  pinkskinpaper.y=-20;
    //paperinshape = true;

  lifes -= 1;
  pinkskinpaper.draw();
  print("-1 life!");
}

if(blockindactorpapertouch.pointInShape(rainbowskinpaper.x,rainbowskinpaper.y)&& achframe == false){
  rainbowskinpaper.x=int(random(40,1600));
  rainbowskinpaper.y=-20;
    //paperinshape = true;
  lifes -= 1;
  rainbowskinpaper.draw();
  print("-1 life!");
}

if(blockindactorpapertouch.pointInShape(specialskinpaper.x,specialskinpaper.y)&& achframe == false){
  goldpaperskin.x=int(random(40,1600));
  goldpaperskin.y=-20;
 // paperinshape = true;
  lifes -= 1;
  goldpaperskin.draw();
  print("-1 life!");}
break;
}

if ((mouseButton == LEFT) && (mouseX >= exitbuttonendgame.x && mouseX <= exitbuttonendgame.x + exitbuttonendgame.width &&
     mouseY >= exitbuttonendgame.y && mouseY <= exitbuttonendgame.y + exitbuttonendgame.height)){
      delay(1000);
      print("plr exit of the game");
             String[] data = loadStrings("savedata.txt");
       points = int(data[0]);
       println("The loaded data is: " + points); 
      exit();
 }
if ((mouseButton == LEFT) && (mouseX >= buy1life.x && mouseX <= buy1life.x + buy1life.width &&
     mouseY >= buy1life.y && mouseY <= buy1life.y + buy1life.height) && points >= 15){
      points -= 15;
      gameend = false;
      //gamestart = true;
      lifes = 1;
     }
if(lifes <= 0){
  //gamestart = false;
  gameend = true;
}

while(gameend == true && gameendfirst == 0){
  frameendgame.draw();
  ghdsahusad = true;
  exitbuttonendgame.draw();
  buy1life.draw();
  gameendfirst = 1;
  break;
}
while(gameend == true && gameendfirst == 1){
  frameendgame.draw();
  exitbuttonendgame.draw();
  break;
  //buy1life.draw();
}
  if (key == 'a' && achframe == false) {
    texthelp.x = 2500;
    exittolobby.x=2500;
    textplay1.x=2500;
    textplay2.x=2500;
    textplay3.x=2500;
    textplay4.x=2500;
    textplay5.x=2500;
    textplay6.x=2500;
    textplay7.x=2500;
    textplay8.x=2500;
    textplay9.x=2500;
    textplay10.x=2500;
    closegame23.x=1760;
    //Trash.x -= 25;
    Trash.x -=0;
    gamestart = true;
    
  } else if (key == 'd' && achframe == false) {
    textplay1.x=2500;
    textplay2.x=2500;
    textplay3.x=2500;
    textplay4.x=2500;
    textplay5.x=2500;
    textplay6.x=2500;
    textplay7.x=2500;
    textplay8.x=2500;
    textplay9.x=2500;
    textplay10.x=2500;
    texthelp.x = 2500;
    exittolobby.x=2500;
    closegame23.x=1760;
    //Trash.x += 25;
    Trash.x +=13;
    gamestart = true;
  }
while (movelevels == true) {
    if (key == 'd' && trashxnot1920) {
        Trash.x += 10;
    } if (key == 'a' && trashxnot20) {
        Trash.x -= 10;
    }
    if (key == 'a' && !trashxnot20){
      Trash.x += 0;
    }
    if (key == 'd' && !trashxnot1920){
      Trash.x += 0;
    }
    break;
}



if (Trash.x < 1600 && gamestart == true){
  trashxnot1920 = true;}
    else if (Trash.x  >= 1600 && gamestart == true){
    trashxnot1920 = false;
  }
  
  if (Trash.x > -20 && gamestart == true){
  trashxnot1920 = true;}
    else if (Trash.x  <= -20 && gamestart == true){
    trashxnot1920 = false;
  }

  if (key == 'a' && trashxnot0){
    Trash.x -= 25;}
    else if (key == 'a' && !trashxnot0){
      Trash.x = Trash.x;
}

if (Trash.x <= -30 && gamestart == true){
  trashxnot0 = false;}
  else if (Trash.x > -30 && gamestart == true){
    trashxnot0 = true;
  }

while (gamestart && lifes == 3 && achframe == false){
  life3.draw();
  blockindactorpapertouch.draw();
  break;
}
while (gamestart && lifes == 2 && achframe == false){
  life2.draw();
  blockindactorpapertouch.draw();
  break;
}
while (gamestart && lifes == 1 && achframe == false){
  life1.draw();
  blockindactorpapertouch.draw();
  break;
}
while (gamestart && lifes == 0){
  //life0.draw();
  lifes = 0;
  blockindactorpapertouch.draw();
  break;
}
  while(movelevels == false){
    texthelp.x = 10;
    exittolobby.x=0;
      gamestart = false;
  break;
}
 // if (gamestart == true && Trash.x => 1920 || Trash.x <= 0){
  //}

 while (movelevels){
      levelselect.x=2500;
      level1.x=2500;
      level2.x=2500;
      level3.x=2500;
      level4.x=2500;
      level5.x=2500;
      level6.x=2500;
      level7.x=2500;
      level8.x=2500;
      level9.x=2500;
      level10.x=2500;
      levelselect.draw();
      level1.draw();
      level2.draw();
      level3.draw();
      level4.draw();
      level5.draw();
      level6.draw();
      level7.draw();
      level8.draw();
      level9.draw();
      level10.draw();
      break;
 }
     
    //image2
    if (imageOpened2) {
      block.draw();
     tutorialframe.draw();
     closebutton.draw();
     Xclosetext.draw();
     Goodluck.draw();
    }
         if (!imageOpened2 && (mouseButton == LEFT) && (mouseX >= buttontutorialpng.x && mouseX <= buttontutorialpng.x + buttontutorialpng.width &&
     mouseY >= buttontutorialpng.y && mouseY <= buttontutorialpng.y + buttontutorialpng.height)) {
         buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();

   imageOpened2 = true;
   imageOpened = false;
    }
  if (!imageOpened2) {
     // print("frame tutraial not visibale!");
    }
    //frametutrialclose
    if (imageOpened2 && (mouseButton == LEFT) && (mouseX >= closebutton.x && mouseX <= closebutton.x + closebutton.width &&
     mouseY >= closebutton.y && mouseY <= closebutton.y + closebutton.height) && (mouseX >= Xclosetext.x && mouseX <= Xclosetext.x + Xclosetext.width &&
    mouseY >= Xclosetext.y && mouseY <= Xclosetext.y + Xclosetext.height)) {

    imageOpened2 = false;
    imageOpened = true;
    }
    //img3
       if (imageOpened3) {
     Credits.draw();
     closebutton.draw();
     Xclosetext.draw();
    }
if (!imageOpened3 && (mouseButton == LEFT) && (mouseX >= informationbutton.x && mouseX <= informationbutton.x + informationbutton.width &&
    mouseY >= informationbutton.y && mouseY <= informationbutton.y + informationbutton.height)) {
        buttonclick.loop = false;
       buttonclick.load("buttonclick.mp3");
       buttonclick.play();
   imageOpened2 = false;
   imageOpened3 = true;
   imageOpened = false;
    }
  if (!imageOpened3) {
     // print("frame tutraial not visibale!");
    }
    //frameCreditclose
    if (imageOpened3 && (mouseButton == LEFT) && (mouseX >= closebutton.x && mouseX <= closebutton.x + closebutton.width &&
     mouseY >= closebutton.y && mouseY <= closebutton.y + closebutton.height) && (mouseX >= Xclosetext.x && mouseX <= Xclosetext.x + Xclosetext.width &&
    mouseY >= Xclosetext.y && mouseY <= Xclosetext.y + Xclosetext.height)) {
    imageOpened3 = false;
    imageOpened2 = true;
    imageOpened = true;
    }
    //beta test text draw:
    while(oooo == 1){
    betatesttext.draw();
    //print(firstpaper1);
    break;
    }
  while(firstpaper && sec != 4){
   acfirstpaper.draw();
   sec += 1;
}
        //fps 
    println("fps: "+int(frameRate));
    textSize(45); 
    if (gamestart == false){
    fill(255); 
    text( "fps:"+ int(frameRate), width=1750, height=1050);}
    if (gamestart == true){
      fill(0,255,0);
      text( "fps:"+ int(frameRate), width=30, height=55);}
    //text( "fps:"+ int(frameRate), width=1750, height=1050);
}                  
                                                       //end the code!!!!!!!!!!
