<div align="center">

# ViewFaceCore 
[![Nuget](https://img.shields.io/nuget/v/ViewFaceCore)](https://www.nuget.org/packages/ViewFaceCore/) &nbsp;&nbsp;
[![GitHub license](https://img.shields.io/github/license/ViewFaceCore/ViewFaceCore)](https://github.com/ViewFaceCore/ViewFaceCore/blob/main/LICENSE) &nbsp;&nbsp;
![GitHub stars](https://img.shields.io/github/stars/ViewFaceCore/ViewFaceCore?style=flat) &nbsp;&nbsp;
![GitHub forks](https://img.shields.io/github/forks/ViewFaceCore/ViewFaceCore)

<br/>

ââ [ðª§ å³äº](#ðª§&nbsp;å³äº) &nbsp;| [â­ å¿«éå¼å§](#â­&nbsp;å¿«éå¼å§) &nbsp;| [ð§ æå»º](#ð§&nbsp;æå»º) &nbsp;| [ð ææ¡£](#ð&nbsp;ææ¡£) &nbsp;| [â å¸¸è§é®é¢](#â&nbsp;å¸¸è§é®é¢) &nbsp;| [ð¦ ä½¿ç¨è®¸å¯](#ð¦&nbsp;ä½¿ç¨è®¸å¯) ââ

</div>

## ðª§&nbsp;å³äº
- ä¸ä¸ªåºäº [SeetaFace6](https://github.com/SeetaFace6Open/index) ç .NET äººè¸è¯å«è§£å³æ¹æ¡
- æ¬é¡¹ç®åå°äº [SeetaFaceEngine.Net](https://github.com/iarray/SeetaFaceEngine.Net) çå¯å
- å¼æºãåè´¹ãè·¨å¹³å° (win/linux)

## â­&nbsp;å¿«éå¼å§
- ### åæ¯æç .NET æ¡æ¶ å æä½ç³»ç»  
   | ç®æ æ¡æ¶ |æä½çæ¬ | æä½ç³»ç» |
   | :-: |:-: | :-: |
   | .NET Framework |4.0 | win ( x64/x86 ) |
   | .NET Standard |2.0 | win ( x64/x86 ) |
   | .NET / .NET Core |3.1 | win ( x64/x86 )ãlinux ( arm/arm64/x64 ) |

- ### ç®åçäººè¸ä¿¡æ¯æ£æµ  
   - ä»¥ Windows x64 ä¸ºä¾
   1. ä½¿ç¨ [nuget](https://www.nuget.org) å®è£ä¾èµ
      | ååç§° | æå°çæ¬ | çææä»¶å¤¹ | è¯´æ |
      | :- | :-: | - | - |
      | [ViewFaceCore](https://www.nuget.org/packages/ViewFaceCore/) | `0.3.5` | ââ | ViewFaceCore .NET æ ¸å¿åº |
      | [ViewFaceCore.model.face_detector](https://www.nuget.org/packages/ViewFaceCore.model.face_detector) | `6.0.0` | `models` | äººè¸æ£æµçæ¨¡åæ¯æ |
      | [ViewFaceCore.runtime.win.x64](https://www.nuget.org/packages/ViewFaceCore.runtime.win.x64) | `6.0.2` | `viewfacecore\win\x64` | Windows-x64 çæ¬æºè¿è¡æ¶ |

   2. è·åäººè¸ä¿¡æ¯  
      ```csharp
      using System;
      using System.Drawing;
      using ViewFaceCore.Sharp;
      
      namespace YourFaceProject
      {
          class Program
          {
              static void Main(string[] args)
              {
                  ViewFace face = new ViewFace();
                  string filename = @"[your face image file path]";
                  Bitmap bitmap = (Bitmap)Image.FromFile(filename);
                  var infos = face.FaceDetector(bitmap);
                  Console.WriteLine($"è¯å«å°çäººè¸æ°éï¼{infos.Length} ãäººè¸ä¿¡æ¯ï¼\n");
                  Console.WriteLine($"No.\täººè¸ç½®ä¿¡åº¦\tä½ç½®ä¿¡æ¯");
                  for (int i = 0; i < infos.Length; i++)
                  {
                      Console.WriteLine($"{i}\t{infos[i].Score:f8}\t{infos[i].Location}");
                  }
                  Console.Read();
              }
          }
      }
      ```





## ð§&nbsp;æå»º
- ### **é¡¹ç®ç»æ**

  Bridges  
  Models  
  SeetaFace/index  
  Simples  
  Tests  
  ViewFaceCore  

- ### **å¼åç¯å¢**
   - Visual Studio 2022 (17.0.2)
   - Windows 11 ä¸ä¸ç (21H2)
   - Ubuntu 20.04 (WSL)

- ### **ç¼è¯è¿ç¨**

   `ä½¿ç¨` [SeetaFace6 å¼åå](https://github.com/seetafaceengine/SeetaFace6#%E7%99%BE%E5%BA%A6%E7%BD%91%E7%9B%98) `ç¼è¯`
   | æè¿° | åç¼å | æ¾ç½®è·¯å¾ |
   | - | - | - |
   | å¤´æä»¶ | *.h | `ViewFaceCore\SeetaFace\index\build\include\seeta\` |
   | ââ | ââ | ââ |
   | Windows å¼åå (x64) | *.dll | `ViewFaceCore\SeetaFace\index\build\bin\x64\` |
   | Windows å¼åå (x64) | *.lib | `ViewFaceCore\SeetaFace\index\build\lib\x64\` |
   ||||
   | Windows å¼åå (x86) | *.dll | `ViewFaceCore\SeetaFace\index\build\bin\x86\` |
   | Windows å¼åå (x86) | *.lib | `ViewFaceCore\SeetaFace\index\build\lib\x86\` |
   ||||
   | Ubuntu å¼åå (x64) | *.so | `ViewFaceCore\SeetaFace\index\build\lib64\` |
   | Ubuntu å¼åå (arm64) | *.so | `ViewFaceCore\SeetaFace\index\build\lib\arm64\` |
   | Ubuntu å¼åå (arm) | *.so | `ViewFaceCore\SeetaFace\index\build\lib\arm\` |

   `å¨é¨éæ°ç¼è¯`  
   1. éç½® %VctPath% ç¯å¢åé (å³ï¼vcvarsall.bat èæ¬çè·¯å¾)
      > ä»¥ Visual Studio 2022 ä¸ºä¾ï¼  
      > `C:\Program Files\Microsoft Visual Studio\2022\Community\VC\Auxiliary\Build`
   2. æç§ [SeetaFace ç¼è¯ä¾èµ](https://github.com/SeetaFace6Open/index#%E7%BC%96%E8%AF%91%E4%BE%9D%E8%B5%96) éç½®å¥½ä¾èµå·¥å·
      - æ¬é¡¹ç®ä½¿ç¨ MSVC (win) / GCC (linux on wsl) ç¼è¯å®æ
      > 1. ç¼è¯å·¥å·
      > 2. For linux<br>
      >  GNU Make å·¥å·<br>
      >  GCC æè Clang ç¼è¯å¨
      > 3. For windows<br>
      >  [MSVC](https://visualstudio.microsoft.com/zh-hans/) æè MinGW. <br>
      >  [jom](https://wiki.qt.io/Jom)
      > 4. [CMake](http://www.cmake.org/)
      > 5. ä¾èµæ¶æ<br>
      >  CPU æ¯æ AVX å FMA [å¯é]ï¼x86ï¼æ NENOï¼ARMï¼æ¯æ
   3. é¦åç¼è¯ `OpenRoleZoo `ã`SeetaAuthorize`ã`TenniS` ä¸ä¸ªé¡¹ç®
      - å¨é¡¹ç®ç `craft` æä»¶å¤¹ä¸å¯å¨ shell
      > **`powershell`** > `./build.win.vc14.all.cmd`  
      > **`linux shell(wsl)`** > `./build.linux.all.sh`
   4. ç¶åç¼è¯å¶ä»é¡¹ç® `SeetaMaskDetector`ã`FaceAntiSpoofingX6`ã`FaceBoxes`ã`FaceRecognizer6`ã`FaceTracker6`ã`Landmarker`ã`OpenRoleZoo`ã`PoseEstimator6`ã`QualityAssessor3`ã`SeetaAgePredictor`ã`SeetaAuthorize`ã`SeetaEyeStateDetector`ã`SeetaGenderPredictor`  
      - å¨é¡¹ç®ç `craft` æä»¶å¤¹ä¸å¯å¨ shell
      > **`powershell`** > `./build.win.vc14.all.cmd`  
      > **`linux shell(wsl)`** > `./build.linux.all.sh`


## ð&nbsp;ææ¡£
- [ViewFaceCore API](https://github.com/View12138/ViewFaceCore/blob/master/README_API.md)
- [SeetaFace6 è¯´æ](https://github.com/seetafaceengine/SeetaFace6/blob/master/README.md)
- [SeetaFace å¥é¨æç¨](http://leanote.com/blog/post/5e7d6cecab64412ae60016ef)
- [SeetaFace åæ¥å£è¯´æ](https://github.com/seetafaceengine/SeetaFace6/tree/master/docs)


## â&nbsp;å¸¸è§é®é¢

## ð¦&nbsp;ä½¿ç¨è®¸å¯
<div align="center">

[MIT](https://github.com/ViewFaceCore/ViewFaceCore/blob/main/LICENSE) Â© 2021 View

</din>
