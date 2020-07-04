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

- [ ] B. 인벤토리
- 4개의 이미지를 선택할 수 있는 상호작용 인벤토리
 
- [ ] C. 금고 터치이벤트   
- 금고는 세모와 네모 블록을 합체할 수 있다.
- [다이얼로그](https://www.youtube.com/watch?v=1NCvpZDtTMI&list=PL4vbr3u7UKWp0iM1WIfRjCDTI03u43Zfu&index=12)

- [ ] D. 아이패드 터치이벤트
- 아이패드는 숫자를 입력할 수 있다
- 숫자 배드와 입력 버튼으로 구성됨

- [ ] E. 전환 효과
- 해상도가 좋아질 때 블러나 화이트아웃

- [ ] F. 금고 열림 효과

- [ ] G. 사운드

# 버그
- [ ] 의자, 금고, 소파에 다시 들어가면 녹색네모가 보이는 이슈
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

#그림추가(7/4 오후1시25분)
소파 - 해상도별로
의자 - 깨진 비트 수정
금고
문    - 해상도별로
메인(소파있는 방면) - 해상도별로