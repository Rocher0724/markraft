
public enum CraftElements {
  Water,
  Fire,
  Wind,
  Earth,
  
  Seed, // ? 
  
  
  Wood, // water + earth 
  Steam, // Water + Fire
  Wave, // Water + Wind : 부정적인 요소  
  Rock, // earth + Wind : 풍화작용 -> rock + wind = Sand
  
  Fireplace, //Fire + Wood 
  Sand, // rock + wind : 풍화작용 

  
  MagicOil // 10번째 조합식때 나오게할까? 
}

/*
 * Fireplace + Rock : Iron
 * Iron + wood = Spear
 * Sphere + Water = Fish
 * Fish + Axe = meat
 *
 * M + glass = potion
 *  m + spear = staff
 * m + fish = sheep
 *   m + sheep = human
 *     human + rock = dwayne
 *       dwayne + club = troll
 *   sheep + axe = wool + meet
 *     wool + m = staff + hat
 * 
 * m + diamond = the ring
 *   thering + human = madness slave
 *     medness slave + axe(spear or club) = friendly army
 * m + fireplace = moving house
 * m + egg = magic egg
 *   magic egg + fire(fireplace) = dragon 
 * 
 */