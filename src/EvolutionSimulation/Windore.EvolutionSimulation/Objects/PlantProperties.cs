using System.Linq;
using Windore.Simulations2D.Data;
using Windore.Simulations2D.Util.SMath;

namespace Windore.EvolutionSimulation.Objects
{
    public class PlantProperties : OrganismProperties
    {
        /// <summary>
        /// Gets or sets the property defining the amount of poison per unit of mass
        /// </summary>
        [DataPoint("Toxicity")]
        public Property Toxicity { get => Properties["Toxicity"]; set => Properties["Toxicity"] = value; }

        /// <summary>
        /// Gets or sets the property defining the range in which the plant can reproduce offspring
        /// </summary>
        [DataPoint("ReproductionArea")]
        public Property ReproductionArea { get => Properties["Reproduction Area"]; set => Properties["Reproduction Area"] = value; }

        /// <summary>
        /// Gets or sets the property defining the Energy Production In Low Nutrient Soil
        /// </summary>
        [DataPoint("EnergyProductionInLowNutrientSoil")]
        public Property EnergyProductionInLowNutrientSoil { get => Properties["Energy Production In Low Nutrient Soil"]; set => Properties["Energy Production In Low Nutrient Soil"] = value; }

        /// <inheritdoc/>
        public PlantProperties CreateMutated()
        {
            PlantProperties newProperties = new PlantProperties
            {
                // Copies the dictionary while mutating all properties
                Properties = Properties.ToDictionary(entry => entry.Key,
                    entry => entry.Value.CreateMutated(new Percentage(MutationEffectMagnitude.Value)))
            };
            return newProperties;
        }
    }
}
