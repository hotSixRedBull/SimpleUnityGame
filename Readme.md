﻿# 진행방식
1. 금고에 세모, 네모 블록 합체하면 해상도 높아짐
    - 세모는 의자 위에, 네모는 소파 위에 있음
2. 금고에서 후레시 나옴(특수 후레시) 
    - 이 후레시를 창문에 비추면 숫자가 나오는걸로
3. 창문에 비추면 파란 불빛 나오면서 
    - 해상도 좋아짐
4. 아이패드에서 앱 열고 open 버튼 누르면 해상도 상승
5. 탈출

# 필요한 리소스
## **이미지**
모든 이미지는 5개 씩 필요함
- [x] 금고
- ~~세모블록~~
- [x] 네모블록
- 의자
- [x] 소파
- [x] 방 배경
- 후레시
- 숫자
- [x] 창문
- 파란 불빛 (반투명 이미지)
- 아이패드
- 손잡이가 없는 문

## **사운드**
- 문이 열리는 소리

# 구현 기능
- [x] A. 회전
- 양 옆의 화살표 버튼을 클릭하여 Scene을 변경
- [Changing Scenes](https://www.youtube.com/watch?v=wNl--exin90&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=30)

- [x] B. 인벤토리
- 4개의 이미지를 선택할 수 있는 상호작용 인벤토리
 
- [x] C. 금고 터치이벤트   
- 금고는 세모와 네모 블록을 합체할 수 있다.
- [다이얼로그](https://www.youtube.com/watch?v=1NCvpZDtTMI&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=12)

- [ ] D. 후레쉬 씬
- 후레쉬는 터치시 확대가 되고, 키고 끌 수 있다.

- [ ] E. 아이패드 터치이벤트
- 아이패드는 숫자를 입력할 수 있다
- 숫자 배드와 입력 버튼으로 구성됨

- [ ] F. 전환 효과
- 해상도가 좋아질 때 블러나 화이트아웃

- [ ] G. 금고 열림 효과

- [ ] H. 사운드

# 버그
- [x] 의자, 금고, 소파에 다시 들어가면 녹색네모가 보이는 이슈
- [ ] 

# 확인필요
- 진행방식 3)의 해상도 좋아짐은 어떤 물체의 해상도를 의미하는 지
    - 어떤 물체가 아니고 방 전체+물건들이 점점 더 뚜렷하게 보이는 것임
        1. 금고에 블록 합체 시 해상도 상승
        2. 금고에서 얻은 후레시를 창문에 비추면 파란 불빛으로 정복되면서 해상도 상승
        3. 창문에 적힌 숫자 4자리를 아이패드에 비밀번호로 입력하면 해상도 상승
        4. 아이패드에서 앱 열고 open 버튼 누르면 해상도 상승
        5. 탈출
- 아이패드는 어떻게 접근하는지
    - 아이패드는 인벤토리에서 눌러 작동할 수 있음
- A.회전에서 Scene의 총 개수는? 각 Scene별 배치는?
    - 
- C.의 금고의 합체는 어떻게 진행되는 지 예시필요
    - 픽셀룸과 같음. 
    - 인벤에서 세모, 네모 블럭을 하나씩 금고에 합체하는 것


# 그림설명
[resol1]
 - resol1_main: 첫 화면		/ resol1_side: 첫 화면의 측면
 - resol1_sofa_first: 네모 줍기 전 소파	/ resol1_sofa_later: 네모 주은 뒤 소파
 - resol1_chair_first: 네모 줍기 전 소파	/ resol1_chair_later: 네모 주은 뒤 소파
 - resol1_inven#: 0은 빈 인벤, 1은 하나 차있을 때, 2는 둘 다 차있을 때
 - resol1_gumgo_first: 금고 / second: 네모 하나 넣었을 때	  /  last: 네모 다 넣었을 때(이때 1초 후 렙업)
 - resol1_square: 네모인데 혹시 필요할까봐
 
[resol2]
 - resol2_gumgo_full: 이 장면부터 레벨이 시작함
 - resol2_gumgo_ipad: 손전등 줍고 --> resol2_flash_inven을 인벤에 추가
 - resol2_gumgo_empty: 아이패드까지 다 주워서 빈 금고일 때  --> resol2_ipad_gotwagil을 인벤에 추가
 - resol2_main: 정면샷		/ resol2_side: 측면
 - resol2_sofa_closed: 소파 근접샷(혹시 누를때를 대비)
 - resol2_flash_off: 인벤에서 손전등 클릭 시(off)
 - resol2_flash_on: 인벤에서 손전등 클릭하고 확대된 손전등 클릭 시(on)
 - resol2_flash_on_inven: 불켜진 손전등 인벤토리 추가
 - resol2_window_first: 창문 확대
 - resol2_window_last: 창문에 불켜진 손전등 비출 때	// 마지막 장면
 
[resol3]
 - resol3_main: 정면샷		/ resol3_side: 측면
 - resol3_sofa_closed: 소파 근접샷(혹시 누를때를 대비)
 - resol3_ipad_pw0: 인벤에서 아이패드 클릭 시 이 화면 나옴
 - resol3_ipad_pw1: 비번 하나 누를 때 ~~~ 4까지 감	// 비번은 2020
 - resol3_ipad_app: 비번 다 풀면 이 화면 나옴 --> 앱 클릭하면
 - resol3_ipad_open: 앱 클릭하면 이 화면 나오고 잠깐 뒤 렙업!!
 
[resol4: 탈출 직전]
 - resol4_ipad_open: 이 장면부터 레벨이 시작함. 클릭하면
 - resol4_ipad_app: 이거 나옴... 아래로 가는 화살표 누르고
 - resol4_main: 여기서 문으로 탈출!	// 측면: resol4_side
