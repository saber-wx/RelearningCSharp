//建立第一个module：score.js，里面有一个类score：
//1.含参构造函数，能给当前实例的属性赋值：时间（datetime = 当前时间），玩家Id（playerName）和成绩（score）
//2.静态方法：getBest(playName) ，返回一个score对象
//3.实例方法：save()
//  以及：一个整数值bestOfAll

class score {
    constructor(playerName, score) {
        this.datetime = new Date;
        this.playerName = playerName;
        this.score = score;
    }
    static getBest(playName) {
        return playName.datetime, playName.score, playName.score;
    }
    set GetBest(value) {
        this.playName = value;
    }
    get GetBest() {
        return this.playName;
    }
    save() {

    }
    bestOfAll;
}

