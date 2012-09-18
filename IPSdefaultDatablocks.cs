/**
  * @Author Lukas Joergensen
  * @Description some base datablocks which should help you get started with the IPS Lite
  */
datablock ParticleData(BurningParticles)
{
	//Ikke sikkert det er den samme sti, men partiklen er den stock particle du kan finde I de to FULL templates
   textureName          = "art/shapes/particles/fire.png";
   dragCoeffiecient     = 0;
   gravityCoefficient   = "-0.891331";
   inheritedVelFactor   = 0.00;
   lifetimeMS           = "600";
   lifetimeVarianceMS   = "300";
   useInvAlpha = false;
   spinRandomMin = -30.0;
   spinRandomMax = 30.0;
   thetaMax = "180";
   

   colors[0]     = "1 0.0 0.0 1.0";
   colors[1]     = "1 0.173228 0.173228 1";
   colors[2]     = "1 0.299213 0.299213 0";

   sizes[0]      = "0.192272";
   sizes[1]      = "0";
   sizes[2]      = "6.24733";

   times[0]      = 0.0;
   times[1]      = "0.294118";
   times[2]      = 1.0;
   animTexName = "art/shapes/particles/fire.png";
   sizes[3] = "12.5";
   spinSpeed = "2";
};

/** Graphemitter **/
datablock GraphEmitterNodeData(g_DefaultNode)
{
   timeMultiple = 1;
   
   funcMax = 2000;
   funcMin = 0;
   timeScale = 1;
   ProgressMode = 0;
   
   ejectionPeriodMS = "1";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "1";
   thetaMax = "0";
   thetaMin = "0";
   phiReferenceVel = "0";
   phiVariance = "0";
   particles = "DefaultParticle";
   blendStyle = "ADDITIVE";
   softnessDistance = "0.01";
};

datablock GraphEmitterData(g_DefaultEmitter)
{
   ejectionPeriodMS = "1";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "1";
   thetaMax = "0";
   thetaMin = "0";
   phiReferenceVel = "0";
   phiVariance = "0";
   particles = "DefaultParticle";
   blendStyle = "ADDITIVE";
   softParticles = "0";
   softnessDistance = "1";
};

/** MeshEmitter **/
datablock MeshEmitterData(m_DefaultEmitter)
{
   ejectionPeriodMS = "1";
   periodVarianceMS = "0";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionOffset = "1";
   thetaMax = "0";
   thetaMin = "0";
   phiReferenceVel = "0";
   phiVariance = "0";
   particles = "DefaultParticle";
   blendStyle = "ADDITIVE";
   softnessDistance = "0.01";
};

/** Burningmeshes **/
// De emitters jeg bruger til at showcase ildebrænde
datablock MeshEmitterData(burningmesh : m_DefaultEmitter)
{
   particles = "BurningParticles";
};