//建立第一个module：score.js，里面有一个类score：
//1.含参构造函数，能给当前实例的属性赋值：时间（datetime = 当前时间），玩家Id（playerName）和成绩（score）
//2.静态方法：getBest(playName) ，返回一个score对象
//3.实例方法：save()
//  以及：一个整数值bestOfAll
//score.js对外所有成员，但bestOfAll对外名称为record
//user.js默认对外暴露login() ，另外暴露getNameById() ，隐藏其他属性
//score.js中的getBest()利用user.js的getNameById() ，将玩家名称转换成Id 
class Score {
    constructor(playerName, score) {
        this.datetime = new Date();
        this.playerName = playerName;
        this.score = score;
    }
    static getBest(playName) {
        return new Score = ("", 12);
    }
    set Best(value) {
        this.playName = value;
    }
    get Best() {
        return this.playName;
    }
    save() {

    }
}
var bestOfAll = 0;
export { bestOfAll as record, Score };

