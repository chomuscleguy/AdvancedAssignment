조성우

최종프로젝트에 3D게임을 진행하기 때문에 에셋을 최대한 많이 활용해보자는 생각으로 기능구현보다는 에셋활용에 중점을 뒀습니다.

제목 :
츠키앗테 쿠다사이(사귀어주세요)

장르 :
3D 어드벤쳐

소재 :
부끄러움이 많은 남자학생이 여학생에게 학교에서 고백을 하는 모습을 그려봄

기획의도 :
에셋스토어를 돌아다니다 보니 흥미로운 에셋들이 많았고 무료에셋인데 높은 퀄리티를 자랑하기 때문에 한번 써보고 싶다는 생각이 들었음

특징 :
무료에셋치고는 높은 퀄리티가 나옴, 학창 시절(?) 내 기억속에는 없지만 충분히 있을 법한 그리고 일본 영화나 아니메에서 자주 나오는 고백 장면 등 마치 내가 겪은 기억마냥 흘러 들어오기 때문에 흥미가 생길 법함

내용 :
현재 구현하고자 하는 방향은 학교에서 주변 사람들의 눈을 피해 고백 장소로 달려가 아무도 보지 않을 때 고백을 하는 과정의 게임, 스테이지가 지남에 따라 터무니 없는 등장인물을 등장시켜볼 예정이고 처음에는 국룰 장소인 학교 뒤지만 점차 난이도가 올라가면 교실이나 운동장에서 고백을 하는 모습을 만들어 난이도를 올려볼 예정

![image](https://github.com/chomuscleguy/AdvancedAssignment/assets/145965718/0ce279a2-a8a1-43e4-bc61-fe8a253b5c5c)

사용에셋
학교 배경 : https://assetstore.unity.com/packages/3d/environments/japanese-school-stylized-221256

히로인 : https://assetstore.unity.com/packages/3d/characters/humanoids/latifa-v2-3d-free-anime-style-character-game-ready-vrchat-184723

UI : https://assetstore.unity.com/packages/2d/gui/sweet-land-gui-208285

플레이어 : https://www.mixamo.com/#/?page=2&type=Character (Shannon)

//12/28

빌트인 에셋을 URP로 가져오면서 많은 오류가 있었기 때문에 기능구현에 힘쓸 시간이 더욱 줄어들었습니다.

StartScene과 MainScene을 나누어 작업을 진행

UI작업시 껐다 키는 기능은 Setbool를 이용 스크립트의 사용을 줄여보았습니다.

여유시간이 생기면 설정에서 음향조절을 구현해볼 예정이고 일단은 게임부터 구현해볼 예정

// 12/29
플레이어가 히로인에게 다가갈 경우 RayCast를 통해 고백하기 버튼이 활성화되게 만들었음

아직 미완성이기 때문에 제출 후 수정해나갈 예정

구현
스타트씬에서 메인씬으로 전환
RayCast를 통해 상호작용(강의내용)
FSM(강의내용)

미구현
오브젝트 풀링을 통해 학생들 생성

네비게이션 메시를 통해 학생들의 움직임 구현

RayCast를 더 활용해서 각종 물건들과 상호작용

학생들에게 RayCast를 넣어 일정 수준을 넘으면 GameOver

애니메이션 좀 더 간결하게

히로인 애니메이션 적용

게임 내 UI작업 진행(ESC누르면 설정창, 설정창에서 음향조절 및 게임 종료)

바로 게임을 실행하기 보단 스테이지 선택하나 만들었으면 좋겠음

