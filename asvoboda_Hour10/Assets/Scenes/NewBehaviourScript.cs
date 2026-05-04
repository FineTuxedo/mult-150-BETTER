/*
 * *****************************************************************************
 * _____                         _____      _ _   _      
 * / ____|                       / ____|    (_) | (_)     
 * | |  __  __ _ _ __ ___   ___ | |     _ __ _| |_ _  ___ 
 * | | |_ |/ _` | '_ ` _ \ / _ \| |    | '__| | __| |/ __|
 * | |__| | (_| | | | | | |  __/| |____| |  | | |_| | (__ 
 * \_____|\__,_|_| |_| |_|\___| \_____|_|  |_|\__|_|\___|
 * *****************************************************************************
 * * IMPROVING THE GAME - EXERCISE SELECTION [cite: 221, 225]
 * * * * 1. ADD A TIMER [cite: 227]
 * * Plan: I will modify the GameManager to include a 'float timer' that 
 * * starts at 0 on Start() and increments by Time.deltaTime in Update(). 
 * * When isGameOver becomes true, the timer stops, allowing players to 
 * * compete for the fastest completion time.
 * * * * 2. ADD VARIATIONS OF THE CHAOS BALLS [cite: 228]
 * * Plan: I will create three Chaos Ball prefabs. One will be 2x larger 
 * * to act as a heavy obstacle, and another will be 0.5x scale with 
 * * a 'startSpeed' of 100 to provide a much faster, chaotic challenge.
 * * * * 3. CHANGE THE FOOTSTEPS AUDIO 
 * * Plan: Since the arena floor is Water4Advanced[cite: 61], I'll replace 
 * * the default FPSController footstep clips with water-splashing SFX. 
 * * This fixes the immersion break of hearing solid ground while walking 
 * * on water.
 * * * * 4. MAKE A COMPLEX BUMPER OUT OF MANY SHAPES 
 * * Plan: Instead of a single cube[cite: 96], I will add two angled cubes 
 * * as children to the 'Bumper' object to create a "scoop" shape. This 
 * * gives the player more control over the trajectory of the colored balls.
 * *****************************************************************************
 */