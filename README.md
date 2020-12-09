# 2020_CapstoneDesign_-Hallym.R.V-

## 순서
1. 팀원소개
2. 개발하게 된 이유
3. 개발환경 및 작품 설명
4. 어려웠던 점
5. 시연영상
--------------------------

## 팀원 소개
> 김재경 / 이길재 / 정의훈

--------------------------

## 개발하게 된 이유
● 올해 코로나로 인하여 학교를 못 본 신입생을 위하여 학교를 간접적으로 VR기기를 통해 볼 수 있도록 만들었습니다.

--------------------------

## 개발환경 및 작품 설명
> Unity를 사용해서 개발을 했으며 Unity WebGl Platform을 활용해서 Web 주소를 통해서 누구나 RoadView를 확인 할 수 있습니다.

● **VIVE VR 장비**를 사용해서 한림대학교의 외부는 물론 내부까지 간접적으로 경험하실 수 있습니다.</br> 
● 한림대학교의 길과 구역에 이름이 있다는 것을 모르시는 분들을 위해 자신의 현재위치를 화면에 보여줌으로써 알게 될 것 입니다.</br> 
● 지도 선택으로 가고 싶은 곳을 선택하여 이동할 수 있습니다.</br> 
● **NPC**를 구현해서 **해당 건물의 설명 및 동영상 시청**이 가능합니다.</br> 
● 신입생은 물론 재학생까지 가보지 못한 길, 예상치 못한 곳에 길이 있는 것 등 알려드리기 위해 구현했습니다. </br> 
● VR장비가 없으신 분들은 **Web서버 주소**를 통해 Unity 프로젝트를 올려서 **누구나 접속**이 가능 하도록 구현했습니다.</br> 

### 한림대 VR RoadView 시작화면
<img width = "500" src = "https://user-images.githubusercontent.com/58055104/100534621-4028f600-3254-11eb-88e8-25936242dfe8.png">

### 촬영 지점 표시한 학교 지도
<img width = "500" src= "https://user-images.githubusercontent.com/58055104/100536144-d0ba0300-3261-11eb-9775-4a520dd45257.jpg">

> 학교 지도를 활용하여 중요 장소 및 촬영 동선 선정해서 계획적으로 했습니다.

### VR 장비 VIVE 시연 영상 캡처
<img width = "500" src = "https://user-images.githubusercontent.com/58055104/101622639-a84cb880-3a5a-11eb-88f4-94281c4fe89f.png">

> VR 장비 VIVE로 가상현실 세계에서 학교를 간접 경험하도록 구현했습니다.

### Web서버에 올린 Unity(http://caerang.hallym.ac.kr/vr/index.html)
<img width ="500" src = "https://user-images.githubusercontent.com/58055104/100530191-21b20300-3232-11eb-9ba5-d924a6d0566e.png" >

> VR 장비가 없을 경우 인터넷만 된다면 누구든 Web 주소를 통해 학교 RoadView를 체험 할 수 있습니다.


--------------------------

## 고려해야 했던 점
1. 촬영 기기 선택

|        |Gopro4|SamSung Gear 360|
|--------|:--------:| :----------:|
|촬영속도(1장 기준) |느림       |   **빠름(O)**   |
|화질    |**좋음(O)**      |   Gopro4 보다는 낮음|
|이동성  |불편함      |   **편리함(O)**|
|배터리(60장 기준)  |  부족함    |   **충분함(O)**|
|사진 촬영 시간(14장 기준)    |1시간 30분 ~2시간|   **30분(O)**|
|Stitching 방법 및 소요시간    |  별도의 프로그램 사용해 Stitching, 시간이 오래 걸림 |  **자동 Stitching, 시간 소요 거의 없음(O)** |
|합계 | 1점 | 5점| 

2. 360사진 이미지 보정
> 직접 찍은 360 사진들에는 자동차 번호판, 지나가는 사람들, 촬영자, 불필요한 요소 삭제 등 이미지 보정을 진행했습니다.
#### <촬영자 삭제>
<img width = "500" src = "https://user-images.githubusercontent.com/58055104/100536363-7a4dc400-3263-11eb-91d3-ab08da6d030c.png">

#### <번호판 가리기>
<img width = "500" src = "https://user-images.githubusercontent.com/58055104/100536465-1a0b5200-3264-11eb-90d0-a82f07fbb71f.png">

## 시연영상

> https://youtu.be/hZwwqKXLcok
