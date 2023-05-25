using Gadolinite.Exercises.Exercises;

namespace Gadolinite.Tests.Exercises
{
    public class AnnalynsInfiltrationTest
    {
        // Check if a fast attack can be made

        [Fact]
        public void CannotExecuteFastAttackWhenKnightIsAwake()
        {
            var knightIsAwake = true;
            Assert.False(AnnalynsInfiltrationExercise.CanFastAttack(knightIsAwake));        
        }

        [Fact]
        public void CannotExecuteFastAttackWhenKnightIsSleeping()
        {
            var knightIsAwake = false;
            Assert.True(AnnalynsInfiltrationExercise.CanFastAttack(knightIsAwake));
        }

        // Check if the group can be spied upon

        [Fact]
        public void CannotSpyWhenEveryoneIsSleeping()
        {
            var knightIsAwake = false;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            Assert.False(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenEveryoneButKnightIsSleeping()
        {
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenEveryoneButArcherIsSleeping()
        {
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenEveryoneButPrisonerIsSleeping()
        {
            var knightIsAwake = false;
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenOnlyKnightIsSleeping()
        {
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenOnlyArcherIsSleeping()
        {
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenOnlyPrisonerIsSleeping()
        {
            var knightIsAwake = true;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSpyWhenEveryoneIsAwake()
        {
            var knightIsAwake = true;
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            Assert.True(AnnalynsInfiltrationExercise.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));
        }

        // Check if the prisoner can be signalled

        [Fact]
        public void CanSignalPrisonerWhenArcherIsSleepingAndPrisonerIsAwake()
        {
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            Assert.True(AnnalynsInfiltrationExercise.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSignalPrisonerWhenArcherIsAwakeAndPrisonerIsSleeping()
        {
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            Assert.False(AnnalynsInfiltrationExercise.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSignalPrisonerWhenArcherAndPrisonerAreBothSleeping()
        {
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            Assert.False(AnnalynsInfiltrationExercise.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
        }

        [Fact]
        public void CanSignalPrisonerWhenArcherAndPrisonerAreBothAwake()
        {
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            Assert.False(AnnalynsInfiltrationExercise.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));
        }

        // Check if the prisoner can be freed

        [Fact]
        public void CannotFreePrisonerWhenEveryoneIsAwakeAndPetDogIsPresent()
        {
            var knightIsAwake = true;
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            var petDogIsPresent = true;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenEveryoneIsAwakeAndPetDogIsAbsent()
        {
            var knightIsAwake = true;
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CanFreePrisonerWhenEveryoneIsAsleepAndPetDogIsPresent()
        {
            var knightIsAwake = false;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            var petDogIsPresent = true;
            Assert.True(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenEveryoneIsAsleepAndPetDogIsAbsent()
        {
            var knightIsAwake = false;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CanFreePriconserWhenOnlyPrisonerIsAwakeAndPetDogIsPresent()
        {
            var knightIsAwake = false;
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            var petDogIsPresent = true;
            Assert.True(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CanFreePrisonerWhenOnlyPrisonerIsAwakeAndPetDogIsAbsent()
        {
            var knightIsAwake = false;
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            var petDogIsPresent = false;
            Assert.True(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyArcherIsAwakeAndPetDogIsPresent()
        {
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            var petDogIsPresent = true;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyArcherIsAwakeAndPetDogIsAbsent()
        {
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CanFreePrisonerWhenOnlyKnightIsAwakeAndPetDogIsPresent()
        {
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            var petDogIsPresent = true;
            Assert.True(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyKnightIsAwakeAndPetDogIsAbsent()
        {
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = false;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyKnightIsAsleepAndPetDogIsPresent()
        {
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            var petDogIsPresent = true;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyKnightIsAsleepAndPetDogIsAbsent()
        {
            var knightIsAwake = false;
            var archerIsAwake = true;
            var prisonerIsAwake = true;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CanFreePrisonerWhenOnlyArcherIsAsleepAndPetDogIsPresent()
        {
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            var petDogIsPresent = true;
            Assert.True(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyArcherIsAsleepAndPetdogIsAbsent()
        {
            var knightIsAwake = true;
            var archerIsAwake = false;
            var prisonerIsAwake = true;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyPrisonerIsAsleepAndPetdogIsPresent()
        {
            var knightIsAwake = true;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            var petDogIsPresent = true;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }

        [Fact]
        public void CannotFreePrisonerWhenOnlyPrisonerIsAsleepAndPetdogIsAbsent()
        {
            var knightIsAwake = true;
            var archerIsAwake = true;
            var prisonerIsAwake = false;
            var petDogIsPresent = false;
            Assert.False(AnnalynsInfiltrationExercise.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));
        }
    }
}
