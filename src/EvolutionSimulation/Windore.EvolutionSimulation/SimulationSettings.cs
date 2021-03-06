using System.IO;
using Windore.Settings.Base;
using Windore.EvolutionSimulation.Objects;

namespace Windore.EvolutionSimulation
{
    public class SimulationSettings
    {
        #region General Settings

        [Setting("Start Paused", "General")]
        public bool StartPaused { get; set; } = false;

        [Setting("Simulation Area Side Length", "General")]
        [DoubleSettingValueLimits(100, 2000)]
        public double SimulationSceneSideLength { get; set; } = 1_500;

        [Setting("Mutation Probability", "General")]
        [DoubleSettingValueLimits(0, 100)]
        public double MutationProbability { get; set; } = 10;

        [Setting("Randomness Seed (0 for random seed)", "General")]
        public int RandomnessSeed { get; set; } = 0;

        [Setting("Simulation Log Directory", "General")]
        [StringSettingIsPath]
        public string SimulationLogDirectory { get; set; } = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments), "EvolutionSimulationLogs/");

        #endregion

        #region Environment Properties

        #region Base Env

        [Setting("Temperature", "Base Environment Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double BaseEnvTemperature { get; set; } = 30;
        [Setting("Environmental Toxin Content", "Base Environment Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double BaseEnvEnvironmentalToxinContent { get; set; } = 10;
        [Setting("Soil Nutrient Content", "Base Environment Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double BaseEnvSoilNutrientContent { get; set; } = 10;

        [Setting("Temperature Change Per Update", "Base Environment Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double BaseEnvTemperatureCPU { get; set; } = 0.0002;
        [Setting("Environmental Toxin Content Change Per Update", "Base Environment Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double BaseEnvEnvironmentalToxinContentCPU { get; set; } = 0;
        [Setting("Soil Nutrient Content Change Per Update", "Base Environment Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double BaseEnvSoilNutrientContentCPU { get; set; } = 0;

        [Setting("Reverse Value Changing", "Base Environment Properties")]
        public bool BaseEnvReverseChanging { get; set; } = true;

        #endregion

        #region Center Env

        [Setting("Temperature Difference From Base", "Center Environment Properties")]
        [DoubleSettingValueLimits(-100, 100)]
        public double CEnvTemperature { get; set; } = 0;
        [Setting("Environmental Toxin Content Difference From Base", "Center Environment Properties")]
        [DoubleSettingValueLimits(-100, 100)]
        public double CEnvEnvironmentalToxinContent { get; set; } = 0;
        [Setting("Soil Nutrient Content Difference From Base", "Center Environment Properties")]
        [DoubleSettingValueLimits(-20, 20)]
        public double CEnvSoilNutrientContent { get; set; } = 0;

        [Setting("Temperature Max Difference From Base", "Center Environment Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double CEnvTemperatureMaxDiff { get; set; } = 0;
        [Setting("Environmental Toxin Content Max Difference From Base", "Center Environment Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double CEnvEnvironmentalToxinContentMaxDiff { get; set; } = 0;
        [Setting("Soil Nutrient Content Max Difference From Base", "Center Environment Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double CEnvSoilNutrientContentMaxDiff { get; set; } = 10;

        [Setting("Temperature Difference Change Per Update", "Center Environment Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double CEnvTemperatureCPU { get; set; } = 0;
        [Setting("Environmental Toxin Content Difference Change Per Update", "Center Environment Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double CEnvEnvironmentalToxinContentCPU { get; set; } = 0;
        [Setting("Soil Nutrient Content Difference Change Per Update", "Center Environment Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double CEnvSoilNutrientContentCPU { get; set; } = -0.0001d;

        [Setting("Reverse Difference Value Changing", "Center Environment Properties")]
        public bool CEnvReverseChanging { get; set; } = true;

        #endregion
    
        #region Side 1 Env

        [Setting("Temperature Difference From Base", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(-100, 100)]
        public double S1EnvTemperature { get; set; } = 5;
        [Setting("Environmental Toxin Content Difference From Base", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(-100, 100)]
        public double S1EnvEnvironmentalToxinContent { get; set; } = 0;
        [Setting("Soil Nutrient Content Difference From Base", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(-20, 20)]
        public double S1EnvSoilNutrientContent { get; set; } = 0;

        [Setting("Temperature Max Difference From Base", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double S1EnvTemperatureMaxDiff { get; set; } = 20;
        [Setting("Environmental Toxin Content Max Difference From Base", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double S1EnvEnvironmentalToxinContentMaxDiff { get; set; } = 0;
        [Setting("Soil Nutrient Content Max Difference From Base", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double S1EnvSoilNutrientContentMaxDiff { get; set; } = 0;

        [Setting("Temperature Difference Change Per Update", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double S1EnvTemperatureCPU { get; set; } = -0.002d;
        [Setting("Environmental Toxin Content Difference Change Per Update", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double S1EnvEnvironmentalToxinContentCPU { get; set; } = 0;
        [Setting("Soil Nutrient Content Difference Change Per Update", "Side Environment 1 Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double S1EnvSoilNutrientContentCPU { get; set; } = 0;

        [Setting("Reverse Difference Value Changing", "Side Environment 1 Properties")]
        public bool S1EnvReverseChanging { get; set; } = true;

        #endregion
      
        #region Side 2 Env

        [Setting("Temperature Difference From Base", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(-100, 100)]
        public double S2EnvTemperature { get; set; } = 0;
        [Setting("Environmental Toxin Content Difference From Base", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(-100, 100)]
        public double S2EnvEnvironmentalToxinContent { get; set; } = -10;
        [Setting("Soil Nutrient Content Difference From Base", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(-20, 20)]
        public double S2EnvSoilNutrientContent { get; set; } = 0;

        [Setting("Temperature Max Difference From Base", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double S2EnvTemperatureMaxDiff { get; set; } = 0;
        [Setting("Environmental Toxin Content Max Difference From Base", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double S2EnvEnvironmentalToxinContentMaxDiff { get; set; } = 60;
        [Setting("Soil Nutrient Content Max Difference From Base", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double S2EnvSoilNutrientContentMaxDiff { get; set; } = 0;

        [Setting("Temperature Difference Change Per Update", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double S2EnvTemperatureCPU { get; set; } = 0;
        [Setting("Environmental Toxin Content Difference Change Per Update", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double S2EnvEnvironmentalToxinContentCPU { get; set; } = 0.002d;
        [Setting("Soil Nutrient Content  Difference Change Per Update", "Side Environment 2 Properties")]
        [DoubleSettingValueLimits(-1, 1)]
        public double S2EnvSoilNutrientContentCPU { get; set; } = 0;

        [Setting("Reverse Difference Value Changing", "Side Environment 2 Properties")]
        public bool S2EnvReverseChanging { get; set; } = true;

        #endregion

        #endregion

        #region Plant Starting Properties

        public PlantProperties StartingPlantProperties { get; } = new PlantProperties
        {
            AdultSize = new Property(20, 1, 1000, 50),
            MutationEffectMagnitude = new Property(1, 0.5, 40, 5),
            ReproductionEnergy = new Property(50, 0, 100, 50),
            OffspringAmount = new Property(2, 1, 10, 3),
            BackupEnergy = new Property(10, 0, 100, 20),
            OptimalTemperature = new Property(30, 0, 80, 50),
            TemperatureChangeResistance = new Property(3, 1, 100, 10),
            EnvironmentalToxinResistance = new Property(0, 0, 100, 10),
            Toxicity = new Property(0, 0, 100, 10),
            ReproductionArea = new Property(40, 1, 300, 50),
            EnergyProductionInLowNutrientSoil = new Property(2, 0, 20, 15)
        };

        [Setting("Adult Size", "Plant Starting Properties")]
        [DoubleSettingValueLimits(1, 1000)]
        public double AdultSizePP { get => StartingPlantProperties.AdultSize.Value; set => StartingPlantProperties.AdultSize.Value = value; }

        [Setting("Mutation Effect Magnitude", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0.5, 40)]
        public double MutationEffectMagnitudePP { get => StartingPlantProperties.MutationEffectMagnitude.Value; set => StartingPlantProperties.MutationEffectMagnitude.Value = value; }

        [Setting("Reproduction Energy", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double ReproductionEnergyPP { get => StartingPlantProperties.ReproductionEnergy.Value; set => StartingPlantProperties.ReproductionEnergy.Value = value; }

        [Setting("Offspring Amount", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 10)]
        public double OffspringAmountPP { get => StartingPlantProperties.OffspringAmount.Value; set => StartingPlantProperties.OffspringAmount.Value = value; }


        [Setting("Backup Energy", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double BackupEnergyPP { get => StartingPlantProperties.BackupEnergy.Value; set => StartingPlantProperties.BackupEnergy.Value = value; }

        [Setting("Optimal Temperature", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 80)]
        public double OptimalTemperaturePP { get => StartingPlantProperties.OptimalTemperature.Value; set => StartingPlantProperties.OptimalTemperature.Value = value; }

        [Setting("Temperature Change Resistance", "Plant Starting Properties")]
        [DoubleSettingValueLimits(1, 100)]
        public double TemperatureChangeResistancePP { get => StartingPlantProperties.TemperatureChangeResistance.Value; set => StartingPlantProperties.TemperatureChangeResistance.Value = value; }

        [Setting("Environmental Toxin Resistance", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double EnvironmentalToxinResistancePP { get => StartingPlantProperties.EnvironmentalToxinResistance.Value; set => StartingPlantProperties.EnvironmentalToxinResistance.Value = value; }

        [Setting("Toxicity", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double ToxicityPP { get => StartingPlantProperties.Toxicity.Value; set => StartingPlantProperties.Toxicity.Value = value; }

        [Setting("Reproduction Area", "Plant Starting Properties")]
        [DoubleSettingValueLimits(1, 300)]
        public double ReproductionAreaPP { get => StartingPlantProperties.ReproductionArea.Value; set => StartingPlantProperties.ReproductionArea.Value = value; }

        [Setting("Energy Production In Low Nutrient Soil", "Plant Starting Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double EnergyProductionInLowNutrientSoilPP { get => StartingPlantProperties.EnergyProductionInLowNutrientSoil.Value; set => StartingPlantProperties.EnergyProductionInLowNutrientSoil.Value = value; }

        #endregion

        #region Animal Starting Properties

        public AnimalProperties StartingAnimalProperties { get; } = new AnimalProperties
        {
            AdultSize = new Property(20, 1, 1000, 50),
            MutationEffectMagnitude = new Property(1, 0.5, 40, 5),
            ReproductionEnergy = new Property(50, 0, 100, 50),
            OffspringAmount = new Property(2, 1, 10, 3),
            BackupEnergy = new Property(10, 0, 100, 20),
            OptimalTemperature = new Property(30, 0, 80, 50),
            TemperatureChangeResistance = new Property(5, 1, 100, 10),
            EnvironmentalToxinResistance = new Property(0, 0, 100, 10),
            MovementSpeed = new Property(20, 0, 60, 10),
            PredationTendency = new Property(50, 0, 100, 50),
            Eyesight = new Property(20, 0, 100, 20),
            AttackPower = new Property(2, 0, 20, 8),
            DefensePower = new Property(2, 0, 20, 8),
            ThreatConsiderationLimit = new Property(10, 0, 40, 15),
            PlantToxicityResistance = new Property(0, 0, 100, 30),
            FoodDigestingSpeed = new Property(10, 1, 100, 10)
        };

        [Setting("Adult Size", "Animal Starting Properties")]
        [DoubleSettingValueLimits(1, 1000)]
        public double AdultSizeAP { get => StartingAnimalProperties.AdultSize.Value; set => StartingAnimalProperties.AdultSize.Value = value; }

        [Setting("Mutation Effect Magnitude", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0.5, 40)]
        public double MutationStrengthAP { get => StartingAnimalProperties.MutationEffectMagnitude.Value; set => StartingAnimalProperties.MutationEffectMagnitude.Value = value; }

        [Setting("Offspring Amount", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 10)]
        public double OffspringAmountAP { get => StartingAnimalProperties.OffspringAmount.Value; set => StartingAnimalProperties.OffspringAmount.Value = value; }

        [Setting("Reproduction Energy", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double ReproductionEnergyAP { get => StartingAnimalProperties.ReproductionEnergy.Value; set => StartingAnimalProperties.ReproductionEnergy.Value = value; }

        [Setting("Backup Energy", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double BackupEnergyAP { get => StartingAnimalProperties.BackupEnergy.Value; set => StartingAnimalProperties.BackupEnergy.Value = value; }

        [Setting("Optimal Temperature", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 80)]
        public double OptimalTemperatureAP { get => StartingAnimalProperties.OptimalTemperature.Value; set => StartingAnimalProperties.OptimalTemperature.Value = value; }

        [Setting("Temperature Change Resistance", "Animal Starting Properties")]
        [DoubleSettingValueLimits(1, 100)]
        public double TemperatureChangeResistanceAP { get => StartingAnimalProperties.TemperatureChangeResistance.Value; set => StartingAnimalProperties.TemperatureChangeResistance.Value = value; }

        [Setting("Environmental Toxin Resistance", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double EnvironmentalToxinResistanceAP { get => StartingAnimalProperties.EnvironmentalToxinResistance.Value; set => StartingAnimalProperties.EnvironmentalToxinResistance.Value = value; }

        [Setting("Movement Speed", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 40)]
        public double MovementSpeedAP { get => StartingAnimalProperties.MovementSpeed.Value; set => StartingAnimalProperties.MovementSpeed.Value = value; }

        [Setting("Predation Tendency", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double PredationTendencyAP { get => StartingAnimalProperties.PredationTendency.Value; set => StartingAnimalProperties.PredationTendency.Value = value; }

        [Setting("Eyesight", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double EyesightAP { get => StartingAnimalProperties.Eyesight.Value; set => StartingAnimalProperties.Eyesight.Value = value; }

        [Setting("Attack Power", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double AttackPowerAP { get => StartingAnimalProperties.AttackPower.Value; set => StartingAnimalProperties.AttackPower.Value = value; }

        [Setting("Defense Power", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 20)]
        public double DefensePowerAP { get => StartingAnimalProperties.DefensePower.Value; set => StartingAnimalProperties.DefensePower.Value = value; }

        [Setting("Threat Consideration Limit", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 40)]
        public double ThreatConsiderationLimitAP { get => StartingAnimalProperties.ThreatConsiderationLimit.Value; set => StartingAnimalProperties.ThreatConsiderationLimit.Value = value; }

        [Setting("Plant Toxicity Resistance", "Animal Starting Properties")]
        [DoubleSettingValueLimits(0, 100)]
        public double PlantToxicityResistanceAP { get => StartingAnimalProperties.PlantToxicityResistance.Value; set => StartingAnimalProperties.PlantToxicityResistance.Value = value; }

        [Setting("Food Digesting Speed", "Animal Starting Properties")]
        [DoubleSettingValueLimits(1, 100)]
        public double FoodDigestingSpeedAP { get => StartingAnimalProperties.FoodDigestingSpeed.Value; set => StartingAnimalProperties.FoodDigestingSpeed.Value = value; }

        #endregion
    }
}
