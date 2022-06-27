# CCTVMaskDetection - 방역관제 CCTV 시스템
![화면 캡처 2021-11-07 123653](https://user-images.githubusercontent.com/36991763/140631455-19247402-1b0a-4a96-8979-d00368a5d0f8.png)

## 2021년 울산대학교 IT융합학부 Team Conatus 졸업작품
- 20162149 손우진
  - 팀장, AI & 영상처리 로직 개발, 기술 연구개발
  - 관제 애플리케이션 기획 및 개발 감독
- 20184259 박화성
  - 영상처리 로직 개발 및 HW 담당
  - 관제 애플리케이션 기능 개발
- 20182098 김효빈
  - 관제 애플리케이션 GUI 개발
### 1. 팀 소개
## 1. Conatus ?
철학 용어에서 나온 이름입니다. 사물이 본디부터 가지고 있고 스스로를 계속 높이려는 경향입니다. 
여기서 사물이란 심리적, 물리적 실체를 말하는데
우리 팀은 분명 실력자들이 모여있던 팀은 아니였지만 우리 실력에서 만들 수 없을 줄 알았던
어려운 작품에 도전함으로써 스스로의 인사이트를 넗힘과 동시에 실력 또한 상승시키자는 의미에서
Conatus라는 팀 이름을 사용하기로 했습니다. 

### 2. 프로그램 소개
![그림1](https://user-images.githubusercontent.com/36991763/140631470-3c794548-60ad-4e9e-a9bb-64e3cfc0a633.png)
저희 방역관제 CCTV 시스템은 CCTV 영상에서 마스크를 쓰지 않은 사람을 탐지해내는 프로그램입니다. 
2020년 부터 COVID 19가 전 세계 적으로 유행을 하고 있습니다.
이러한 상황에서 우리는 사회적으로 도움이 될 수 있는 졸업작품 주제를 선택해보기로 했습니다. 
결국 감염병이라는 건 개인 방역의 유지 만큼 좋은 예방법은 없다고 생각합니다.
그래서 우리는 IT 기술을 통해 실내에서 사람들이 개인 방역을 지킬 수 있도록 해보자는 생각으로 많은 회의 끝에, 
마스크 착용 여부를 CCTV로 판별 해 보자고 판단하였고 직접 구현 해 보았습니다. 

### 3. 프로그램 사용법
![image](https://user-images.githubusercontent.com/36991763/175933375-3a185527-510e-4e2a-bbc9-90bdb05f7b0c.png)
카메라를 사용하기 위해서는 직접 카메라 장치를 프로그램에 등록해야 합니다. Webcam 을 사용한다면, 입력 순서에 따라 0부터 N까지의 숫자를 주소로 사용하면 됩니다.
Ip카메라라면 RTSP 주소를 입력하면 됩니다.
![image](https://user-images.githubusercontent.com/36991763/175933552-0bb5ef72-310d-42dd-96f9-c28366847d77.png)
현재는 Webcam 두 개를 연결 시킨 상황입니다. 전원 버튼을 누르면 각 화면 별로 등록 되어있는 카메라 영상이 출력되기 시작합니다. 
콘솔 창에는 현재 화면의 모니터링 현황이 출력됩니다.

![image](https://user-images.githubusercontent.com/36991763/175933744-2ab9f8f7-3b25-42df-aba9-949d64bc0854.png)
각 화면 별로 영상을 녹화하거나 캡쳐 할 수 있습니다. 지정 된 경로에 영상이나 이미지가 저장됩니다. 
