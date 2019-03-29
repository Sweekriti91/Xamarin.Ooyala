﻿using System;
using AVFoundation;
using CoreGraphics;
using CoreMedia;
using Foundation;
using MediaAccessibility;
using ObjCRuntime;
using UIKit;

namespace OoyalaSDK.tvOS
{
    // typedef void (^OOCurrentItemChangedCallback)(OOVideo *);
    delegate void OOCurrentItemChangedCallback(OOVideo arg0);

    // typedef void (^OOContentTreeCallback)(OOContentItem *, OOOoyalaError *);
    delegate void OOContentTreeCallback(OOContentItem arg0, OOOoyalaError arg1);

    // typedef void (^OOVideoAuthCallback)(OOVideo *, OOOoyalaError *);
    delegate void OOVideoAuthCallback(OOVideo arg0, OOOoyalaError arg1);

    // typedef void (^OOContentTreeNextCallback)(NSRange, OOOoyalaError *);
    delegate void OOContentTreeNextCallback(NSRange arg0, OOOoyalaError arg1);

    // typedef void (^OOMetadataDictionaryFromAPICallback)(OOOoyalaError *);
    delegate void OOMetadataDictionaryFromAPICallback(OOOoyalaError arg0);

    // typedef void (^OOFetchMoreChildrenCallback)(NSRange, OOOoyalaError *);
    delegate void OOFetchMoreChildrenCallback(NSRange arg0, OOOoyalaError arg1);

    // typedef void (^OOObjectFromBacklotAPICallback)(NSObject *);
    delegate void OOObjectFromBacklotAPICallback(NSObject arg0);

    // typedef void (^OOAuthorizeCallback)(OOOoyalaError *);
    delegate void OOAuthorizeCallback(OOOoyalaError arg0);

    // typedef void (^OOHeartbeatCallback)(OOOoyalaError *);
    delegate void OOHeartbeatCallback(OOOoyalaError arg0);

    // typedef void (^OOGeoblockingCallback)(NSData *, NSHTTPURLResponse *, NSError *);
    delegate void OOGeoblockingCallback(NSData arg0, NSHttpUrlResponse arg1, NSError arg2);

    // @interface OOOoyalaPlayerStateConverter : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface OOOoyalaPlayerStateConverter
    {
        // +(NSString *)playerStateToString:(OOOoyalaPlayerState)state;
        [Static]
        [Export("playerStateToString:")]
        string PlayerStateToString(OOOoyalaPlayerState state);

        // +(NSString *)playerDesiredStateToString:(OOOoyalaPlayerDesiredState)desiredState;
        [Static]
        [Export("playerDesiredStateToString:")]
        string PlayerDesiredStateToString(OOOoyalaPlayerDesiredState desiredState);
    }

    // [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // // extern NSString *const OOOoyalaPlayerTimeChangedNotification;
        // [Field ("OOOoyalaPlayerTimeChangedNotification")]
        // NSString OOOoyalaPlayerTimeChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerStateChangedNotification;
        // [Field ("OOOoyalaPlayerStateChangedNotification")]
        // NSString OOOoyalaPlayerStateChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerDesiredStateChangedNotification;
        // [Field ("OOOoyalaPlayerDesiredStateChangedNotification")]
        // NSString OOOoyalaPlayerDesiredStateChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerContentTreeReadyNotification;
        // [Field ("OOOoyalaPlayerContentTreeReadyNotification")]
        // NSString OOOoyalaPlayerContentTreeReadyNotification { get; }

        // // extern NSString *const OOOoyalaPlayerMetadataReadyNotification;
        // [Field ("OOOoyalaPlayerMetadataReadyNotification")]
        // NSString OOOoyalaPlayerMetadataReadyNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAuthorizationReadyNotification;
        // [Field ("OOOoyalaPlayerAuthorizationReadyNotification")]
        // NSString OOOoyalaPlayerAuthorizationReadyNotification { get; }

        // // extern NSString *const OOOoyalaPlayerCurrentItemChangedNotification;
        // [Field ("OOOoyalaPlayerCurrentItemChangedNotification")]
        // NSString OOOoyalaPlayerCurrentItemChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerPlayStartedNotification;
        // [Field ("OOOoyalaPlayerPlayStartedNotification")]
        // NSString OOOoyalaPlayerPlayStartedNotification { get; }

        // // extern NSString *const OOOoyalaplayerLicenseAcquisitionNotification;
        // [Field ("OOOoyalaplayerLicenseAcquisitionNotification")]
        // NSString OOOoyalaplayerLicenseAcquisitionNotification { get; }

        // // extern NSString *const OOOoyalaPlayerPlayCompletedNotification;
        // [Field ("OOOoyalaPlayerPlayCompletedNotification")]
        // NSString OOOoyalaPlayerPlayCompletedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdOverlayNotification;
        // [Field ("OOOoyalaPlayerAdOverlayNotification")]
        // NSString OOOoyalaPlayerAdOverlayNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdPodStartedNotification;
        // [Field ("OOOoyalaPlayerAdPodStartedNotification")]
        // NSString OOOoyalaPlayerAdPodStartedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdStartedNotification;
        // [Field ("OOOoyalaPlayerAdStartedNotification")]
        // NSString OOOoyalaPlayerAdStartedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdCompletedNotification;
        // [Field ("OOOoyalaPlayerAdCompletedNotification")]
        // NSString OOOoyalaPlayerAdCompletedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdPodCompletedNotification;
        // [Field ("OOOoyalaPlayerAdPodCompletedNotification")]
        // NSString OOOoyalaPlayerAdPodCompletedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdsLoadedNotification;
        // [Field ("OOOoyalaPlayerAdsLoadedNotification")]
        // NSString OOOoyalaPlayerAdsLoadedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdSkippedNotification;
        // [Field ("OOOoyalaPlayerAdSkippedNotification")]
        // NSString OOOoyalaPlayerAdSkippedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdTappedNotification;
        // [Field ("OOOoyalaPlayerAdTappedNotification")]
        // NSString OOOoyalaPlayerAdTappedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerContentResumedAfterAdNotification;
        // [Field ("OOOoyalaPlayerContentResumedAfterAdNotification")]
        // NSString OOOoyalaPlayerContentResumedAfterAdNotification { get; }

        // // extern NSString *const OOOoyalaPlayerErrorNotification;
        // [Field ("OOOoyalaPlayerErrorNotification")]
        // NSString OOOoyalaPlayerErrorNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAdErrorNotification;
        // [Field ("OOOoyalaPlayerAdErrorNotification")]
        // NSString OOOoyalaPlayerAdErrorNotification { get; }

        // // extern NSString *const OOOoyalaPlayerCCManifestChangedNotification;
        // [Field ("OOOoyalaPlayerCCManifestChangedNotification")]
        // NSString OOOoyalaPlayerCCManifestChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerLanguageChangedNotification;
        // [Field ("OOOoyalaPlayerLanguageChangedNotification")]
        // NSString OOOoyalaPlayerLanguageChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerSeekStartedNotification;
        // [Field ("OOOoyalaPlayerSeekStartedNotification")]
        // NSString OOOoyalaPlayerSeekStartedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerSeekCompletedNotification;
        // [Field ("OOOoyalaPlayerSeekCompletedNotification")]
        // NSString OOOoyalaPlayerSeekCompletedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerJsonReceivedNotification;
        // [Field ("OOOoyalaPlayerJsonReceivedNotification")]
        // NSString OOOoyalaPlayerJsonReceivedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerEmbedCodeSetNotification;
        // [Field ("OOOoyalaPlayerEmbedCodeSetNotification")]
        // NSString OOOoyalaPlayerEmbedCodeSetNotification { get; }

        // // extern NSString *const OOOoyalaPlayerBitrateChangedNotification;
        // [Field ("OOOoyalaPlayerBitrateChangedNotification")]
        // NSString OOOoyalaPlayerBitrateChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerBufferingStartedNotification;
        // [Field ("OOOoyalaPlayerBufferingStartedNotification")]
        // NSString OOOoyalaPlayerBufferingStartedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerBufferingCompletedNotification;
        // [Field ("OOOoyalaPlayerBufferingCompletedNotification")]
        // NSString OOOoyalaPlayerBufferingCompletedNotification { get; }

        // // extern NSString *const OOOoyalaplayerExternalPlaybackActiveNotification;
        // [Field ("OOOoyalaplayerExternalPlaybackActiveNotification")]
        // NSString OOOoyalaplayerExternalPlaybackActiveNotification { get; }

        // // extern NSString *const OOLiveClosedCaptionsLanguage;
        // [Field ("OOLiveClosedCaptionsLanguage")]
        // NSString OOLiveClosedCaptionsLanguage { get; }

        // // extern NSString *const OOOoyalaPlayerVideoHasVRContent;
        // [Field ("OOOoyalaPlayerVideoHasVRContent")]
        // NSString OOOoyalaPlayerVideoHasVRContent { get; }

        // // extern NSString *const OOOoyalaVRPlayerDidConfigured;
        // [Field ("OOOoyalaVRPlayerDidConfigured")]
        // NSString OOOoyalaVRPlayerDidConfigured { get; }

        // // extern NSString *const OOOoyalaPlayerSwitchSceneNotification;
        // [Field ("OOOoyalaPlayerSwitchSceneNotification")]
        // NSString OOOoyalaPlayerSwitchSceneNotification { get; }

        // // extern NSString *const OOOoyalaPlayerHandleTouchNotification;
        // [Field ("OOOoyalaPlayerHandleTouchNotification")]
        // NSString OOOoyalaPlayerHandleTouchNotification { get; }

        // // extern NSString *const OOOoyalaPlayerMultiAudioEnabledNotification;
        // [Field ("OOOoyalaPlayerMultiAudioEnabledNotification")]
        // NSString OOOoyalaPlayerMultiAudioEnabledNotification { get; }

        // // extern NSString *const OOOoyalaPlayerAudioTrackChangedNotification;
        // [Field ("OOOoyalaPlayerAudioTrackChangedNotification")]
        // NSString OOOoyalaPlayerAudioTrackChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerSsaiAdsMetadataReceivedNotification;
        // [Field ("OOOoyalaPlayerSsaiAdsMetadataReceivedNotification")]
        // NSString OOOoyalaPlayerSsaiAdsMetadataReceivedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerSsaiPlaySingleAdNotification;
        // [Field ("OOOoyalaPlayerSsaiPlaySingleAdNotification")]
        // NSString OOOoyalaPlayerSsaiPlaySingleAdNotification { get; }

        // // extern NSString *const OOOoyalaPlayerSsaiSingleAdPlayedNotification;
        // [Field ("OOOoyalaPlayerSsaiSingleAdPlayedNotification")]
        // NSString OOOoyalaPlayerSsaiSingleAdPlayedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerPlaybackSpeedEnabledNotification;
        // [Field ("OOOoyalaPlayerPlaybackSpeedEnabledNotification")]
        // NSString OOOoyalaPlayerPlaybackSpeedEnabledNotification { get; }

        // // extern NSString *const OOOoyalaPlayerPlaybackSpeedRateChangedChangedNotification;
        // [Field ("OOOoyalaPlayerPlaybackSpeedRateChangedChangedNotification")]
        // NSString OOOoyalaPlayerPlaybackSpeedRateChangedChangedNotification { get; }

        // // extern NSString *const OOOoyalaPlayerApplicationVolumeChangedNotification;
        // [Field ("OOOoyalaPlayerApplicationVolumeChangedNotification")]
        // NSString OOOoyalaPlayerApplicationVolumeChangedNotification { get; }
    }

    // @interface OOOoyalaPlayer : NSObject
    [BaseType(typeof(NSObject))]
    //Hack
    interface OOOoyalaPlayer : OOOoyalaPlayer_Playback, OOOoyalaPlayer_MultiAudio, OOOoyalaPlayer_AdPluginManagement
    {
        // +(void)setEnvironment:(OOOoyalaPlayerEnvironment)e;
        [Static]
        [Export("setEnvironment:")]
        void SetEnvironment(OOOoyalaPlayerEnvironment e);

        // +(void)setSSLEnvironmentEnabled:(BOOL)sslEnabled;
        [Static]
        [Export("setSSLEnvironmentEnabled:")]
        void SetSSLEnvironmentEnabled(bool sslEnabled);

        // +(NSString *)version;
        [Static]
        [Export("version")]
        // [Verify (MethodToProperty)]
        string Version { get; }

        // +(BOOL)useDebugDRMPlayback;
        // +(void)setUseDebugDRMPlayback:(BOOL)enable;
        [Static]
        [Export("useDebugDRMPlayback")]
        // [Verify (MethodToProperty)]
        bool UseDebugDRMPlayback { get; set; }

        // +(BOOL)encryptedLoopback;
        // +(void)setEncryptedLoopback:(BOOL)enabled;
        [Static]
        [Export("encryptedLoopback")]
        // [Verify (MethodToProperty)]
        bool EncryptedLoopback { get; set; }

        // +(OOIQAnalyticsTrackingState)iqAnalyticsTrackingState;
        // +(void)setIqAnalyticsTrackingState:(OOIQAnalyticsTrackingState)state;
        [Static]
        [Export("iqAnalyticsTrackingState")]
        // [Verify (MethodToProperty)]
        OOIQAnalyticsTrackingState IqAnalyticsTrackingState { get; set; }

        // @property (readonly, nonatomic) OOVideo * currentItem;
        [Export("currentItem")]
        OOVideo CurrentItem { get; }

        // @property (readonly, nonatomic) OOContentItem * rootItem;
        [Export("rootItem")]
        OOContentItem RootItem { get; }

        // @property (readonly, nonatomic) NSDictionary * metadata;
        [Export("metadata")]
        NSDictionary Metadata { get; }

        // @property (readonly, nonatomic) OOOoyalaError * error;
        [Export("error")]
        OOOoyalaError Error { get; }

        // @property (readonly, nonatomic) OOOoyalaPlayerSessionIDManager * sessionIDManager;
        [Export("sessionIDManager")]
        //Hack
        NSObject SessionIDManager { get; }

        // @property (readonly, nonatomic) UIView * view;
        [Export("view")]
        UIView View { get; }

        // @property (nonatomic) OOOoyalaPlayerVideoGravity videoGravity;
        [Export("videoGravity", ArgumentSemantic.Assign)]
        OOOoyalaPlayerVideoGravity VideoGravity { get; set; }

        // @property (readonly, nonatomic) BOOL supportsVideoGravityButton;
        [Export("supportsVideoGravityButton")]
        bool SupportsVideoGravityButton { get; }

        // @property (nonatomic) BOOL seekable;
        [Export("seekable")]
        bool Seekable { get; set; }

        // @property (nonatomic) BOOL adsSeekable;
        [Export("adsSeekable")]
        bool AdsSeekable { get; set; }

        // @property (readonly, nonatomic) OOSeekStyle seekStyle;
        [Export("seekStyle")]
        OOSeekStyle SeekStyle { get; }

        // @property (nonatomic) NSString * closedCaptionsLanguage;
        [Export("closedCaptionsLanguage")]
        string ClosedCaptionsLanguage { get; set; }

        // @property (readonly, nonatomic) BOOL isAudioOnlyStreamPlaying;
        [Export("isAudioOnlyStreamPlaying")]
        bool IsAudioOnlyStreamPlaying { get; }

        // @property (readonly, getter = isClosedCaptionsTrackAvailable, nonatomic) BOOL closedCaptionsTrackAvailable;
        [Export("closedCaptionsTrackAvailable")]
        bool ClosedCaptionsTrackAvailable { [Bind("isClosedCaptionsTrackAvailable")] get; }

        // @property (nonatomic) OOCurrentItemChangedCallback currentItemChangedCallback;
        [Export("currentItemChangedCallback", ArgumentSemantic.Assign)]
        OOCurrentItemChangedCallback CurrentItemChangedCallback { get; set; }

        // @property (nonatomic) OOOoyalaPlayerActionAtEnd actionAtEnd;
        [Export("actionAtEnd", ArgumentSemantic.Assign)]
        OOOoyalaPlayerActionAtEnd ActionAtEnd { get; set; }

        // @property (readonly, getter = isExternalPlaybackActive, nonatomic) BOOL externalPlaybackActive;
        [Export("externalPlaybackActive")]
        bool ExternalPlaybackActive { [Bind("isExternalPlaybackActive")] get; }

        // @property (nonatomic) BOOL allowsExternalPlayback;
        [Export("allowsExternalPlayback")]
        bool AllowsExternalPlayback { get; set; }

        // @property (nonatomic) BOOL usesExternalPlaybackWhileExternalScreenIsActive;
        [Export("usesExternalPlaybackWhileExternalScreenIsActive")]
        bool UsesExternalPlaybackWhileExternalScreenIsActive { get; set; }

        // @property (nonatomic) float playbackRate;
        [Export("playbackRate")]
        float PlaybackRate { get; set; }

        // @property (readonly, nonatomic) NSString * authToken;
        [Export("authToken")]
        string AuthToken { get; }

        // @property (readonly, nonatomic) NSString * playerSessionId;
        [Export("playerSessionId")]
        string PlayerSessionId { get; }

        // @property (readonly, nonatomic) NSString * contentSessionId;
        [Export("contentSessionId")]
        string ContentSessionId { get; }

        // @property (nonatomic) float volume;
        [Export("volume")]
        float Volume { get; set; }

        // @property (nonatomic) NSString * userAgent;
        [Export("userAgent")]
        string UserAgent { get; set; }

        [Wrap("WeakAssetLoaderDelegate")]
        OOAssetLoaderDelegate AssetLoaderDelegate { get; set; }

        // @property (nonatomic) OOAssetLoaderDelegate * assetLoaderDelegate;
        [NullAllowed, Export("assetLoaderDelegate", ArgumentSemantic.Assign)]
        NSObject WeakAssetLoaderDelegate { get; set; }

        // @property (nonatomic) NSString * customDrmData;
        [Export("customDrmData")]
        string CustomDrmData { get; set; }

        // @property (readonly, nonatomic) OOStreamPlayerMapping * streamPlayerMapping;
        [Export("streamPlayerMapping")]
        //Hack
        NSObject StreamPlayerMapping { get; }
        //OOStreamPlayerMapping StreamPlayerMapping { get; }

        // @property (readonly, nonatomic) NSString * pcode;
        [Export("pcode")]
        string Pcode { get; }

        // @property (readonly, nonatomic) OOOoyalaPlayerDesiredState desiredState;
        [Export("desiredState")]
        OOOoyalaPlayerDesiredState DesiredState { get; }

        // @property (readonly, nonatomic) OOManagedAdsPlugin * managedAdsPlugin;
        [Export("managedAdsPlugin")]
        OOManagedAdsPlugin ManagedAdsPlugin { get; }

        // @property (readonly, nonatomic) OOOptions * options;
        [Export("options")]
        OOOptions Options { get; }

        // @property (nonatomic) OOUIProgressSliderMode normalSliderMode;
        [Export("normalSliderMode", ArgumentSemantic.Assign)]
        OOUIProgressSliderMode NormalSliderMode { get; set; }

        // @property (nonatomic) OOAudioSession * audioSession;
        [Export("audioSession", ArgumentSemantic.Assign)]
        //Hack
        NSObject AudioSession { get; set; }

        // -(instancetype)initWithOoyalaAPIClient:(OOOoyalaAPIClient *)apiClient;
        [Export("initWithOoyalaAPIClient:")]
        IntPtr Constructor(OOOoyalaAPIClient apiClient);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain;
        [Export("initWithPcode:domain:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain options:(OOOptions *)options;
        [Export("initWithPcode:domain:options:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain, OOOptions options);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain embedTokenGenerator:(id<OOEmbedTokenGenerator>)embedTokenGenerator;
        [Export("initWithPcode:domain:embedTokenGenerator:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain, OOEmbedTokenGenerator embedTokenGenerator);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain embedTokenGenerator:(id<OOEmbedTokenGenerator>)embedTokenGenerator options:(OOOptions *)options;
        [Export("initWithPcode:domain:embedTokenGenerator:options:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain, OOEmbedTokenGenerator embedTokenGenerator, OOOptions options);

        // -(void)setDesiredState:(OOOoyalaPlayerDesiredState)desiredState;
        [Export("setDesiredState:")]
        void SetDesiredState(OOOoyalaPlayerDesiredState desiredState);

        // -(BOOL)setStream:(OOStream *)stream;
        [Export("setStream:")]
        bool SetStream(OOStream stream);

        // -(BOOL)setStreams:(NSArray *)streams;
        [Export("setStreams:")]
        //[Verify(StronglyTypedNSArray)]
        bool SetStreams(NSObject[] streams);

        // -(BOOL)setUnbundledVideo:(OOUnbundledVideo *)unbundledVideo;
        [Export("setUnbundledVideo:")]
        bool SetUnbundledVideo(OOUnbundledVideo unbundledVideo);

        // -(BOOL)setEmbedCode:(NSString *)embedCode;
        [Export("setEmbedCode:")]
        bool SetEmbedCode(string embedCode);

        // -(BOOL)setEmbedCodes:(NSArray *)embedCodes;
        [Export("setEmbedCodes:")]
        //[Verify(StronglyTypedNSArray)]
        bool SetEmbedCodes(NSObject[] embedCodes);

        // -(BOOL)setEmbedCode:(NSString *)embedCode adSetCode:(NSString *)adSetCode;
        [Export("setEmbedCode:adSetCode:")]
        bool SetEmbedCode(string embedCode, string adSetCode);

        // -(BOOL)setEmbedCodes:(NSArray *)embedCodes adSetCode:(NSString *)adSetCode;
        [Export("setEmbedCodes:adSetCode:")]
        //[Verify(StronglyTypedNSArray)]
        bool SetEmbedCodes(NSObject[] embedCodes, string adSetCode);

        // -(BOOL)setExternalId:(NSString *)externalId;
        [Export("setExternalId:")]
        bool SetExternalId(string externalId);

        // -(BOOL)setExternalIds:(NSArray *)externalIds;
        [Export("setExternalIds:")]
        //[Verify(StronglyTypedNSArray)]
        bool SetExternalIds(NSObject[] externalIds);

        // -(void)setRootItem:(OOContentItem *)theRootItem;
        [Export("setRootItem:")]
        void SetRootItem(OOContentItem theRootItem);

        // -(void)setAsset:(NSDictionary *)asset;
        [Export("setAsset:")]
        void SetAsset(NSDictionary asset);

        // -(BOOL)changeCurrentItemToEmbedCode:(NSString *)embedCode;
        [Export("changeCurrentItemToEmbedCode:")]
        bool ChangeCurrentItemToEmbedCode(string embedCode);

        // -(BOOL)changeCurrentItemToVideo:(OOVideo *)video;
        [Export("changeCurrentItemToVideo:")]
        bool ChangeCurrentItemToVideo(OOVideo video);

        // -(BOOL)changeUnbundledVideo:(OOVideo *)video;
        [Export("changeUnbundledVideo:")]
        bool ChangeUnbundledVideo(OOVideo video);

        // -(void)reauthorizeCurrentItemWithCallback:(OOAuthorizeCallback)callback;
        [Export("reauthorizeCurrentItemWithCallback:")]
        void ReauthorizeCurrentItemWithCallback(OOAuthorizeCallback callback);

        // -(OOOoyalaPlayerState)state;
        //[Export("state")]
        //OOOoyalaPlayerState State();

        // -(void)setCustomAnalyticsTags:(NSArray *)tags;
        [Export("setCustomAnalyticsTags:")]
        //[Verify(StronglyTypedNSArray)]
        void SetCustomAnalyticsTags(NSObject[] tags);

        // -(void)destroy;
        [Export("destroy")]
        void Destroy();

        // -(OOOoyalaAPIClient *)api;
        [Export("api")]
        OOOoyalaAPIClient Api();

        // -(NSString *)dataFromFile:(NSString *)embedCode;
        [Export("dataFromFile:")]
        string DataFromFile(string embedCode);
    }

    // @protocol OOAdPlugin <NSObject, OOLifeCycle>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOAdPlugin : OOLifeCycle
    {
        // @required -(BOOL)onContentChanged;
        [Abstract]
        [Export("onContentChanged")]
        // [Verify (MethodToProperty)]
        bool OnContentChanged { get; }

        // @required -(BOOL)onInitialPlay;
        [Abstract]
        [Export("onInitialPlay")]
        // [Verify (MethodToProperty)]
        bool OnInitialPlay { get; }

        // @required -(BOOL)onPlayheadUpdate:(Float64)playhead;
        [Abstract]
        [Export("onPlayheadUpdate:")]
        bool OnPlayheadUpdate(double playhead);

        // @required -(BOOL)onContentFinished;
        [Abstract]
        [Export("onContentFinished")]
        // [Verify (MethodToProperty)]
        bool OnContentFinished { get; }

        // @required -(BOOL)onCuePoint:(int)cuePointIndex;
        [Abstract]
        [Export("onCuePoint:")]
        bool OnCuePoint(int cuePointIndex);

        // @required -(BOOL)onContentError:(int)errorCode;
        [Abstract]
        [Export("onContentError:")]
        bool OnContentError(int errorCode);

        // @required -(void)onAdModeEntered;
        [Abstract]
        [Export("onAdModeEntered")]
        void OnAdModeEntered();

        // @required -(id<OOPlayerProtocol>)player;
        [Abstract]
        [Export("player")]
        // [Verify (MethodToProperty)]
        OOPlayerProtocol Player { get; }

        // @required -(void)resetAds;
        [Abstract]
        [Export("resetAds")]
        void ResetAds();

        // @required -(void)skipAd;
        [Abstract]
        [Export("skipAd")]
        void SkipAd();

        // @required -(void)clickAd;
        [Abstract]
        [Export("clickAd")]
        void ClickAd();

        // @required -(NSSet *)getCuePointsAtSeconds;
        [Abstract]
        [Export("getCuePointsAtSeconds")]
        // [Verify (MethodToProperty)]
        NSSet CuePointsAtSeconds { get; }

        // @required -(void)onAdIconClicked:(NSInteger)index;
        [Abstract]
        [Export("onAdIconClicked:")]
        void OnAdIconClicked(nint index);

        // @required -(BOOL)hasNotNilAds;
        [Abstract]
        [Export("hasNotNilAds")]
        // [Verify (MethodToProperty)]
        bool HasNotNilAds { get; }
    }

    // @protocol OOAdPluginManagerProtocol
    [Protocol, Model]
    interface OOAdPluginManagerProtocol
    {
        // @required -(BOOL)registerPlugin:(id<OOAdPlugin>)plugin;
        [Abstract]
        [Export("registerPlugin:")]
        bool RegisterPlugin(OOAdPlugin plugin);

        // @required -(BOOL)deregisterPlugin:(id<OOAdPlugin>)plugin;
        [Abstract]
        [Export("deregisterPlugin:")]
        bool DeregisterPlugin(OOAdPlugin plugin);

        // @required -(BOOL)exitAdMode:(id<OOAdPlugin>)plugin;
        [Abstract]
        [Export("exitAdMode:")]
        bool ExitAdMode(OOAdPlugin plugin);

        // @required -(BOOL)requestAdMode:(id<OOAdPlugin>)plugin;
        [Abstract]
        [Export("requestAdMode:")]
        bool RequestAdMode(OOAdPlugin plugin);

        // @required -(id<OOAdPlugin>)activeAdPlugin;
        [Abstract]
        [Export("activeAdPlugin")]
        // [Verify (MethodToProperty)]
        OOAdPlugin ActiveAdPlugin { get; }
    }

    // @interface AdPluginManagement (OOOoyalaPlayer) <OOAdPluginManagerProtocol>
    //[Category]
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface OOOoyalaPlayer_AdPluginManagement : OOAdPluginManagerProtocol
    {
        // -(void)registerAdPlayer:(Class)adPlayerClass forType:(Class)adClass;
        [Export("registerAdPlayer:forType:")]
        void RegisterAdPlayer(Class adPlayerClass, Class adClass);

        // -(OOStateNotifier *)createStateNotifier;
        [Export("createStateNotifier")]
        // [Verify (MethodToProperty)]
        OOStateNotifier CreateStateNotifier { get; }
    }

    // @interface Ads (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_Ads
    {
        // -(BOOL)needPlayAdsOnInitialContentPlay;
        [Export("needPlayAdsOnInitialContentPlay")]
        // [Verify (MethodToProperty)]
        bool NeedPlayAdsOnInitialContentPlay { get; }

        // -(BOOL)needPlayAds:(OOAdMode)mode withParameter:(NSNumber *)parameter;
        [Export("needPlayAds:withParameter:")]
        bool NeedPlayAds(OOAdMode mode, NSNumber parameter);

        // -(void)switchToContent;
        [Export("switchToContent")]
        void SwitchToContent();

        // -(OOAdType)adType;
        [Export("adType")]
        // [Verify (MethodToProperty)]
        OOAdType AdType { get; }

        // -(void)processExitAdModes:(OOAdMode)mode adsPlayed:(BOOL)played;
        [Export("processExitAdModes:adsPlayed:")]
        void ProcessExitAdModes(OOAdMode mode, bool played);

        // -(void)onAdIconClicked:(NSInteger)index;
        [Export("onAdIconClicked:")]
        void OnAdIconClicked(nint index);

        // -(void)onAdOverlayClicked:(NSString *)clickUrl;
        [Export("onAdOverlayClicked:")]
        void OnAdOverlayClicked(string clickUrl);

        // -(void)insertAds:(NSMutableArray *)ads;
        [Export("insertAds:")]
        void InsertAds(NSMutableArray ads);

        // -(void)clickAd;
        [Export("clickAd")]
        void ClickAd();

        // -(void)resetAds;
        [Export("resetAds")]
        void ResetAds();

        // -(void)skipAd;
        [Export("skipAd")]
        void SkipAd();
    }

    // @interface Playback (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OOOoyalaPlayer_Playback
    {
        // @property (readonly, getter = isPiPActivated, nonatomic) BOOL pipActivated;
        [Export("pipActivated")]
        bool PipActivated { [Bind("isPiPActivated")] get; }

        // @property (readonly, getter = isAudioOnly, nonatomic) BOOL audioOnly;
        [Export("audioOnly")]
        bool AudioOnly { [Bind("isAudioOnly")] get; }

        // -(Float64)duration;
        [Export("duration")]
        // [Verify (MethodToProperty)]
        double Duration { get; }

        // -(double)bitrate;
        [Export("bitrate")]
        // [Verify (MethodToProperty)]
        double Bitrate { get; }

        // -(BOOL)isAuthTokenExpired;
        [Export("isAuthTokenExpired")]
        // [Verify (MethodToProperty)]
        bool IsAuthTokenExpired { get; }

        // -(CMTimeRange)seekableTimeRange;
        [Export("seekableTimeRange")]
        // [Verify (MethodToProperty)]
        CMTimeRange SeekableTimeRange { get; }

        // -(BOOL)isShowingAd;
        [Export("isShowingAd")]
        // [Verify (MethodToProperty)]
        bool IsShowingAd { get; }

        // -(BOOL)isShowingAdWithCustomControls;
        [Export("isShowingAdWithCustomControls")]
        // [Verify (MethodToProperty)]
        bool IsShowingAdWithCustomControls { get; }

        // -(Float64)playheadTime;
        // -(void)setPlayheadTime:(Float64)time;
        [Export("playheadTime")]
        // [Verify (MethodToProperty)]
        double PlayheadTime { get; set; }

        // -(NSDate *)liveTime;
        [Export("liveTime")]
        // [Verify (MethodToProperty)]
        NSDate LiveTime { get; }

        // -(Float64)bufferedTime;
        [Export("bufferedTime")]
        // [Verify (MethodToProperty)]
        double BufferedTime { get; }

        // -(BOOL)isPlaying;
        [Export("isPlaying")]
        // [Verify (MethodToProperty)]
        bool IsPlaying { get; }

        // -(NSSet *)getCuePointsAtSecondsForCurrentPlayer;
        [Export("getCuePointsAtSecondsForCurrentPlayer")]
        // [Verify (MethodToProperty)]
        NSSet CuePointsAtSecondsForCurrentPlayer { get; }

        // -(void)togglePictureInPictureMode;
        [Export("togglePictureInPictureMode")]
        void TogglePictureInPictureMode();

        // -(void)seek:(Float64)time;
        [Export("seek:")]
        void Seek(double time);

        // -(void)seekCompleted;
        [Export("seekCompleted")]
        void SeekCompleted();

        // -(void)pause;
        [Export("pause")]
        void Pause();

        // -(void)play;
        [Export("play")]
        void Play();

        // -(void)playWithInitialTime:(Float64)time;
        [Export("playWithInitialTime:")]
        void PlayWithInitialTime(double time);
    }

    // @interface AppEvents (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_AppEvents
    {
        // -(void)addAppLifeEventsObservers;
        [Export("addAppLifeEventsObservers")]
        void AddAppLifeEventsObservers();
    }

    // @protocol OOPlaybackSpeedProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOPlaybackSpeedProtocol
    {
        // @required @property (readonly, nonatomic) Float64 selectedPlaybackSpeedRate;
        [Abstract]
        [Export("selectedPlaybackSpeedRate")]
        double SelectedPlaybackSpeedRate { get; }

        // @required @property (readonly, getter = isPlaybackSpeedEnabled, nonatomic) BOOL playbackSpeedEnabled;
        [Abstract]
        [Export("playbackSpeedEnabled")]
        bool PlaybackSpeedEnabled { [Bind("isPlaybackSpeedEnabled")] get; }

        // @required -(void)changePlaybackSpeedRate:(Float64)playbackSpeedRate;
        [Abstract]
        [Export("changePlaybackSpeedRate:")]
        void ChangePlaybackSpeedRate(double playbackSpeedRate);
    }

    // @interface PlaybackSpeed (OOOoyalaPlayer) <OOPlaybackSpeedProtocol>
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_PlaybackSpeed : OOPlaybackSpeedProtocol
    {
    }

    // @interface Cast (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_Cast
    {
        // -(void)initCastManager:(OOCastManager *)castManager;
        [Export("initCastManager:")]
        //Hack
        void InitCastManager(NSObject castManager);

        // -(void)switchToCastMode;
        [Export("switchToCastMode")]
        void SwitchToCastMode();

        // -(void)exitCastModeWithEmbedCode:(NSString *)embedCode playheadTime:(Float64)playheadTime isPlaying:(BOOL)isPlaying;
        [Export("exitCastModeWithEmbedCode:playheadTime:isPlaying:")]
        void ExitCastModeWithEmbedCode(string embedCode, double playheadTime, bool isPlaying);

        // -(BOOL)isInCastMode;
        [Export("isInCastMode")]
        //[Verify(MethodToProperty)]
        bool IsInCastMode { get; }
    }

    // @interface PlaybackWorkflow (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_PlaybackWorkflow
    {
        // -(void)prepareContent;
        [Export("prepareContent")]
        void PrepareContent();

        //// -(void)observeValueForKeyPath:(NSString *)keyPath ofObject:(id)object change:(NSDictionary *)change context:(void *)context;
        //[Export("observeValueForKeyPath:ofObject:change:context:")]
        //unsafe void ObserveValueForKeyPath(string keyPath, NSObject @object, NSDictionary change, void* context);

        // -(void)onComplete;
        [Export("onComplete")]
        void OnComplete();

        // -(void)onContentError;
        [Export("onContentError")]
        void OnContentError();

        // -(void)stopPlaybackOnHeartbeatFailure:(OOAuthHeartbeat *)sender;
        [Export("stopPlaybackOnHeartbeatFailure:")]
        //Hack
        void StopPlaybackOnHeartbeatFailure(NSObject sender);
    }

    // @interface Channel (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_Channel
    {
        // -(BOOL)nextVideo;
        [Export("nextVideo")]
        // [Verify (MethodToProperty)]
        bool NextVideo { get; }

        // -(BOOL)previousVideo;
        [Export("previousVideo")]
        // [Verify (MethodToProperty)]
        bool PreviousVideo { get; }

        // -(UIImage *)screenshot;
        [Export("screenshot")]
        // [Verify (MethodToProperty)]
        UIImage Screenshot { get; }
    }

    // @interface ClosedCaptions (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_ClosedCaptions
    {
        // -(void)disablePlaylistClosedCaptions;
        [Export("disablePlaylistClosedCaptions")]
        void DisablePlaylistClosedCaptions();

        // -(NSArray *)availableClosedCaptionsLanguages;
        [Export("availableClosedCaptionsLanguages")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] AvailableClosedCaptionsLanguages { get; }

        // -(NSString *)languageNameToLanguageCode:(NSString *)name;
        [Export("languageNameToLanguageCode:")]
        string LanguageNameToLanguageCode(string name);
    }

    // @interface MoviePlayerCreation (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_MoviePlayerCreation
    {
        // -(OOMoviePlayer *)getCorrectMoviePlayer:(OOVideo *)video;
        [Export("getCorrectMoviePlayer:")]
        //Hack
        NSObject GetCorrectMoviePlayer(OOVideo video);
    }

    // @interface UI (OOOoyalaPlayer)
    [Protocol]
    [BaseType(typeof(OOOoyalaPlayer))]
    interface OOOoyalaPlayer_UI
    {
        // -(void)showPromoImage;
        [Export("showPromoImage")]
        void ShowPromoImage();

        // -(void)hidePromoImage;
        [Export("hidePromoImage")]
        void HidePromoImage();

        // -(CGRect)videoRect;
        [Export("videoRect")]
        // [Verify (MethodToProperty)]
        CGRect VideoRect { get; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();
    }

    // @protocol OOMultiAudioProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOMultiAudioProtocol
    {
        // @required -(NSArray * _Nonnull)availableAudioTracks;
        [Abstract]
        [Export("availableAudioTracks")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] AvailableAudioTracks { get; }

        // @required -(id<OOAudioTrackProtocol> _Nullable)selectedAudioTrack;
        [Abstract]
        [NullAllowed, Export("selectedAudioTrack")]
        // [Verify (MethodToProperty)]
        OOAudioTrackProtocol SelectedAudioTrack { get; }

        // @required -(void)setAudioTrack:(id<OOAudioTrackProtocol> _Nonnull)audioTrack;
        [Abstract]
        [Export("setAudioTrack:")]
        void SetAudioTrack(OOAudioTrackProtocol audioTrack);

        // @required -(void)setDefaultAudioTrackLanguageCode:(NSString * _Nonnull)defaultAudioTrackLanguageCode;
        [Abstract]
        [Export("setDefaultAudioTrackLanguageCode:")]
        void SetDefaultAudioTrackLanguageCode(string defaultAudioTrackLanguageCode);

        // @required -(void)setDefaultConfigAudioTrackLanguageCode:(NSString * _Nonnull)defaultConfigAudioTrackLanguageCode;
        [Abstract]
        [Export("setDefaultConfigAudioTrackLanguageCode:")]
        void SetDefaultConfigAudioTrackLanguageCode(string defaultConfigAudioTrackLanguageCode);

        // @required -(id<OOAudioTrackProtocol> _Nullable)defaultAudioTrack;
        // @required -(void)setDefaultAudioTrack:(id<OOAudioTrackProtocol> _Nonnull)audioTrack;
        [Abstract]
        [NullAllowed, Export("defaultAudioTrack")]
        // [Verify (MethodToProperty)]
        OOAudioTrackProtocol DefaultAudioTrack { get; set; }
    }

    // @interface MultiAudio (OOOoyalaPlayer) <OOMultiAudioProtocol>
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface OOOoyalaPlayer_MultiAudio : OOMultiAudioProtocol
    {
        // -(BOOL)hasMultipleAudioTracks;
        [Export("hasMultipleAudioTracks")]
        // [Verify (MethodToProperty)]
        bool HasMultipleAudioTracks { get; }
    }

    // @interface OOFCCTVRatingConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface OOFCCTVRatingConfiguration
    {
        // @property (readonly, nonatomic) int durationSeconds;
        [Export("durationSeconds")]
        int DurationSeconds { get; }

        // @property (readonly, nonatomic) OOFCCTvRatingsPosition position;
        [Export("position")]
        OOFCCTvRatingsPosition Position { get; }

        // @property (readonly, nonatomic) CGFloat scale;
        [Export("scale")]
        nfloat Scale { get; }

        // @property (readonly, nonatomic) CGFloat opacity;
        [Export("opacity")]
        nfloat Opacity { get; }

        // -(instancetype)initWithDurationSeconds:(int)durationSeconds position:(OOFCCTvRatingsPosition)position scale:(CGFloat)scale opacity:(CGFloat)opacity;
        [Export("initWithDurationSeconds:position:scale:opacity:")]
        IntPtr Constructor(int durationSeconds, OOFCCTvRatingsPosition position, nfloat scale, nfloat opacity);
    }

    // @interface OODeviceInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface OODeviceInfo
    {
        // @property NSString * browser;
        [Export("browser")]
        string Browser { get; set; }

        // @property NSString * browserVersion;
        [Export("browserVersion")]
        string BrowserVersion { get; set; }

        // @property NSString * os;
        [Export("os")]
        string Os { get; set; }

        // @property NSString * osVersion;
        [Export("osVersion")]
        string OsVersion { get; set; }

        // @property NSString * deviceType;
        [Export("deviceType")]
        string DeviceType { get; set; }

        // @property NSString * deviceBrand;
        [Export("deviceBrand")]
        string DeviceBrand { get; set; }

        // @property NSString * model;
        [Export("model")]
        string Model { get; set; }

        // -(instancetype)initWithBrowser:(NSString *)browser browserVersion:(NSString *)browserVersion os:(NSString *)os osVersion:(NSString *)osVersion deviceBrand:(NSString *)deviceBrand model:(NSString *)model;
        [Export("initWithBrowser:browserVersion:os:osVersion:deviceBrand:model:")]
        IntPtr Constructor(string browser, string browserVersion, string os, string osVersion, string deviceBrand, string model);
    }

    [Static]
    // [Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_PLAYER_ID;
        // [Field ("OOIQCONFIGURATION_DEFAULT_PLAYER_ID")]
        // NSString OOIQCONFIGURATION_DEFAULT_PLAYER_ID { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_ANALYTICS_JS_URL;
        // [Field ("OOIQCONFIGURATION_DEFAULT_ANALYTICS_JS_URL")]
        // NSString OOIQCONFIGURATION_DEFAULT_ANALYTICS_JS_URL { get; }

        // // extern const int OOIQCONFIGURATION_DEFAULT_ANALYTICS_JS_TIMEOUT;
        // [Field ("OOIQCONFIGURATION_DEFAULT_ANALYTICS_JS_TIMEOUT")]
        // int OOIQCONFIGURATION_DEFAULT_ANALYTICS_JS_TIMEOUT { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_DOMAIN;
        // [Field ("OOIQCONFIGURATION_DEFAULT_DOMAIN")]
        // NSString OOIQCONFIGURATION_DEFAULT_DOMAIN { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_BACKEND_ENDPOINT_URL;
        // [Field ("OOIQCONFIGURATION_DEFAULT_BACKEND_ENDPOINT_URL")]
        // NSString OOIQCONFIGURATION_DEFAULT_BACKEND_ENDPOINT_URL { get; }

        // // extern const int OOIQCONFIGURATION_DEFAULT_BACKEND_ENDPOINT_TIMEOUT;
        // [Field ("OOIQCONFIGURATION_DEFAULT_BACKEND_ENDPOINT_TIMEOUT")]
        // int OOIQCONFIGURATION_DEFAULT_BACKEND_ENDPOINT_TIMEOUT { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_BROWSER;
        // [Field ("OOIQCONFIGURATION_DEFAULT_BROWSER")]
        // NSString OOIQCONFIGURATION_DEFAULT_BROWSER { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_BROWSER_VERSION;
        // [Field ("OOIQCONFIGURATION_DEFAULT_BROWSER_VERSION")]
        // NSString OOIQCONFIGURATION_DEFAULT_BROWSER_VERSION { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_OS;
        // [Field ("OOIQCONFIGURATION_DEFAULT_OS")]
        // NSString OOIQCONFIGURATION_DEFAULT_OS { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_OS_VERSION;
        // [Field ("OOIQCONFIGURATION_DEFAULT_OS_VERSION")]
        // NSString OOIQCONFIGURATION_DEFAULT_OS_VERSION { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_DEVICE_BRAND;
        // [Field ("OOIQCONFIGURATION_DEFAULT_DEVICE_BRAND")]
        // NSString OOIQCONFIGURATION_DEFAULT_DEVICE_BRAND { get; }

        // // extern NSString *const OOIQCONFIGURATION_DEFAULT_MODEL;
        // [Field ("OOIQCONFIGURATION_DEFAULT_MODEL")]
        // NSString OOIQCONFIGURATION_DEFAULT_MODEL { get; }

        // // extern const BOOL OOIQCONFIGURATION_DEFAULT_NETWORK_WIFI;
        // [Field ("OOIQCONFIGURATION_DEFAULT_NETWORK_WIFI")]
        // bool OOIQCONFIGURATION_DEFAULT_NETWORK_WIFI { get; }
    }

    // @interface OOIQConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    interface OOIQConfiguration
    {
        // @property (nonatomic) NSString * playerID;
        [Export("playerID")]
        string PlayerID { get; set; }

        // @property (nonatomic) NSString * analyticsJSURL;
        [Export("analyticsJSURL")]
        string AnalyticsJSURL { get; set; }

        // @property (nonatomic) int analyticsJSRequestTimeout;
        [Export("analyticsJSRequestTimeout")]
        int AnalyticsJSRequestTimeout { get; set; }

        // @property (nonatomic) NSString * domain;
        [Export("domain")]
        string Domain { get; set; }

        // @property (nonatomic) NSString * backendEndpointURL;
        [Export("backendEndpointURL")]
        string BackendEndpointURL { get; set; }

        // @property (nonatomic) int backendEndpointTimeout;
        [Export("backendEndpointTimeout")]
        int BackendEndpointTimeout { get; set; }

        // @property (nonatomic) OODeviceInfo * deviceInfo;
        [Export("deviceInfo", ArgumentSemantic.Assign)]
        OODeviceInfo DeviceInfo { get; set; }

        // @property (nonatomic) BOOL useWifiOnly;
        [Export("useWifiOnly")]
        bool UseWifiOnly { get; set; }
    }

    // @protocol OOSecureURLGenerator <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOSecureURLGenerator
    {
        // @required -(NSURL *)secureURL:(NSString *)host uri:(NSString *)uri params:(NSDictionary *)params;
        [Abstract]
        [Export("secureURL:uri:params:")]
        NSUrl Uri(string host, string uri, NSDictionary @params);
    }

    // @interface OOOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface OOOptions
    {
        // @property (nonatomic) OOFCCTVRatingConfiguration * tvRatingConfiguration;
        [Export("tvRatingConfiguration", ArgumentSemantic.Assign)]
        OOFCCTVRatingConfiguration TvRatingConfiguration { get; set; }

        // @property (nonatomic) OOIQConfiguration * iqConfiguration;
        [Export("iqConfiguration", ArgumentSemantic.Assign)]
        OOIQConfiguration IqConfiguration { get; set; }

        // @property (nonatomic) BOOL showCuePoints;
        [Export("showCuePoints")]
        bool ShowCuePoints { get; set; }

        // @property (nonatomic) BOOL showLiveContentScrubber;
        [Export("showLiveContentScrubber")]
        bool ShowLiveContentScrubber { get; set; }

        // @property (nonatomic) BOOL showAdsControls;
        [Export("showAdsControls")]
        bool ShowAdsControls { get; set; }

        // @property (nonatomic) BOOL preloadContent;
        [Export("preloadContent")]
        bool PreloadContent { get; set; }

        // @property (nonatomic) BOOL showPromoImage;
        [Export("showPromoImage")]
        bool ShowPromoImage { get; set; }

        // @property (nonatomic) NSTimeInterval connectionTimeout;
        [Export("connectionTimeout")]
        double ConnectionTimeout { get; set; }

        // @property (nonatomic) id<OOSecureURLGenerator> secureURLGenerator;
        [Export("secureURLGenerator", ArgumentSemantic.Assign)]
        OOSecureURLGenerator SecureURLGenerator { get; set; }

        // @property (nonatomic) BOOL enablePictureInPictureSupport;
        [Export("enablePictureInPictureSupport")]
        bool EnablePictureInPictureSupport { get; set; }

        [Wrap("WeakPipDelegate")]
        //HACK
        //AVPictureInPictureControllerDelegate PipDelegate { get; set; }
        NSObject PipDelegate { get; set; }

        // @property (nonatomic, weak) id<AVPictureInPictureControllerDelegate> pipDelegate;
        [NullAllowed, Export("pipDelegate", ArgumentSemantic.Weak)]
        NSObject WeakPipDelegate { get; set; }

        // @property (nonatomic) BOOL bypassPCodeMatching;
        [Export("bypassPCodeMatching")]
        bool BypassPCodeMatching { get; set; }

        // @property (nonatomic) id<OOPlayerInfo> playerInfo;
        [Export("playerInfo", ArgumentSemantic.Assign)]
        OOPlayerInfo PlayerInfo { get; set; }

        // @property (nonatomic) BOOL disableVASTOoyalaAds;
        [Export("disableVASTOoyalaAds")]
        bool DisableVASTOoyalaAds { get; set; }

        // @property (nonatomic) NSArray<NSString *> * dynamicFilters;
        [Export("dynamicFilters", ArgumentSemantic.Assign)]
        string[] DynamicFilters { get; set; }

        // @property (getter = isHEVCEnabled, nonatomic) BOOL HEVCEnabled;
        [Export("HEVCEnabled")]
        bool HEVCEnabled { [Bind("isHEVCEnabled")] get; set; }

        // @property (nonatomic) Float64 initialPlaybackSpeedRate;
        [Export("initialPlaybackSpeedRate")]
        double InitialPlaybackSpeedRate { get; set; }

        // -(void)logProperties;
        [Export("logProperties")]
        void LogProperties();
    }

    // @interface OOPlayerDomain : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface OOPlayerDomain
    {
        // +(instancetype)domainWithString:(NSString *)string;
        [Static]
        [Export("domainWithString:")]
        OOPlayerDomain DomainWithString(string @string);

        // -(instancetype)initWithString:(NSString *)domainStr;
        [Export("initWithString:")]
        IntPtr Constructor(string domainStr);

        // -(NSString *)asString;
        [Export("asString")]
        // [Verify (MethodToProperty)]
        string AsString { get; }

        // -(NSURL *)asURL;
        [Export("asURL")]
        // [Verify (MethodToProperty)]
        NSUrl AsURL { get; }
    }

    // @protocol OOPlayerInfo <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOPlayerInfo
    {
        // @required @property (readonly, nonatomic) NSString * device;
        [Abstract]
        [Export("device")]
        string Device { get; }

        // @required @property (readonly, nonatomic) NSArray * supportedFormats;
        [Abstract]
        [Export("supportedFormats")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] SupportedFormats { get; }

        // @required @property (readonly, nonatomic) NSArray * supportedProfiles;
        [Abstract]
        [Export("supportedProfiles")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] SupportedProfiles { get; }

        // @required @property (readonly, nonatomic) int maxWidth;
        [Abstract]
        [Export("maxWidth")]
        int MaxWidth { get; }

        // @required @property (readonly, nonatomic) int maxHeight;
        [Abstract]
        [Export("maxHeight")]
        int MaxHeight { get; }

        // @required @property (readonly, nonatomic) int maxBitrate;
        [Abstract]
        [Export("maxBitrate")]
        int MaxBitrate { get; }

        // @required @property (readonly, nonatomic) NSString * userAgent;
        [Abstract]
        [Export("userAgent")]
        string UserAgent { get; }

        // @required @property (readonly, nonatomic) NSDictionary * additionalParams;
        [Abstract]
        [Export("additionalParams")]
        NSDictionary AdditionalParams { get; }

        // @required @property (readonly, nonatomic) BOOL isAudioOnly;
        [Abstract]
        [Export("isAudioOnly")]
        bool IsAudioOnly { get; }
    }

    // @interface OODefaultPlayerInfo : NSObject <OOPlayerInfo>
    [BaseType(typeof(NSObject))]
    interface OODefaultPlayerInfo : OOPlayerInfo
    {
    }

    // @interface OODefaultAudioOnlyPlayerInfo : OODefaultPlayerInfo
    [BaseType(typeof(OODefaultPlayerInfo))]
    [Protocol]
    interface OODefaultAudioOnlyPlayerInfo
    {
    }

    //[Static]
    // [Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // // extern const float OO_MINIMUM_SUPPORTED_VAST_VERSION;
        // [Field ("OO_MINIMUM_SUPPORTED_VAST_VERSION")]
        // float OO_MINIMUM_SUPPORTED_VAST_VERSION { get; }

        // // extern const float OO_MAXIMUM_SUPPORTED_VAST_VERSION;
        // [Field ("OO_MAXIMUM_SUPPORTED_VAST_VERSION")]
        // float OO_MAXIMUM_SUPPORTED_VAST_VERSION { get; }

        // // extern const float OO_MINIMUM_SUPPORTED_VMAP_VERSION;
        // [Field ("OO_MINIMUM_SUPPORTED_VMAP_VERSION")]
        // float OO_MINIMUM_SUPPORTED_VMAP_VERSION { get; }

        // // extern const float OO_MAXIMUM_SUPPORTED_VMAP_VERSION;
        // [Field ("OO_MAXIMUM_SUPPORTED_VMAP_VERSION")]
        // float OO_MAXIMUM_SUPPORTED_VMAP_VERSION { get; }

        // // extern char *const OO_ELEMENT_VAST;
        // [Field ("OO_ELEMENT_VAST")]
        // unsafe sbyte* OO_ELEMENT_VAST { get; }

        // // extern char *const OO_ELEMENT_AD;
        // [Field ("OO_ELEMENT_AD")]
        // unsafe sbyte* OO_ELEMENT_AD { get; }

        // // extern char *const OO_ELEMENT_IN_LINE;
        // [Field ("OO_ELEMENT_IN_LINE")]
        // unsafe sbyte* OO_ELEMENT_IN_LINE { get; }

        // // extern char *const OO_ELEMENT_WRAPPER;
        // [Field ("OO_ELEMENT_WRAPPER")]
        // unsafe sbyte* OO_ELEMENT_WRAPPER { get; }

        // // extern char *const OO_ELEMENT_AD_SYSTEM;
        // [Field ("OO_ELEMENT_AD_SYSTEM")]
        // unsafe sbyte* OO_ELEMENT_AD_SYSTEM { get; }

        // // extern char *const OO_ELEMENT_AD_TITLE;
        // [Field ("OO_ELEMENT_AD_TITLE")]
        // unsafe sbyte* OO_ELEMENT_AD_TITLE { get; }

        // // extern char *const OO_ELEMENT_DESCRIPTION;
        // [Field ("OO_ELEMENT_DESCRIPTION")]
        // unsafe sbyte* OO_ELEMENT_DESCRIPTION { get; }

        // // extern char *const OO_ELEMENT_SURVEY;
        // [Field ("OO_ELEMENT_SURVEY")]
        // unsafe sbyte* OO_ELEMENT_SURVEY { get; }

        // // extern char *const OO_ELEMENT_ERROR;
        // [Field ("OO_ELEMENT_ERROR")]
        // unsafe sbyte* OO_ELEMENT_ERROR { get; }

        // // extern char *const OO_ELEMENT_IMPRESSION;
        // [Field ("OO_ELEMENT_IMPRESSION")]
        // unsafe sbyte* OO_ELEMENT_IMPRESSION { get; }

        // // extern char *const OO_ELEMENT_CREATIVES;
        // [Field ("OO_ELEMENT_CREATIVES")]
        // unsafe sbyte* OO_ELEMENT_CREATIVES { get; }

        // // extern char *const OO_ELEMENT_CREATIVE;
        // [Field ("OO_ELEMENT_CREATIVE")]
        // unsafe sbyte* OO_ELEMENT_CREATIVE { get; }

        // // extern char *const OO_ELEMENT_LINEAR;
        // [Field ("OO_ELEMENT_LINEAR")]
        // unsafe sbyte* OO_ELEMENT_LINEAR { get; }

        // // extern char *const OO_ELEMENT_NONLINEAR;
        // [Field ("OO_ELEMENT_NONLINEAR")]
        // unsafe sbyte* OO_ELEMENT_NONLINEAR { get; }

        // // extern char *const OO_ELEMENT_NON_LINEAR_ADS;
        // [Field ("OO_ELEMENT_NON_LINEAR_ADS")]
        // unsafe sbyte* OO_ELEMENT_NON_LINEAR_ADS { get; }

        // // extern char *const OO_ELEMENT_COMPANION_ADS;
        // [Field ("OO_ELEMENT_COMPANION_ADS")]
        // unsafe sbyte* OO_ELEMENT_COMPANION_ADS { get; }

        // // extern char *const OO_ELEMENT_COMPANION;
        // [Field ("OO_ELEMENT_COMPANION")]
        // unsafe sbyte* OO_ELEMENT_COMPANION { get; }

        // // extern char *const OO_ELEMENT_EXTENSIONS;
        // [Field ("OO_ELEMENT_EXTENSIONS")]
        // unsafe sbyte* OO_ELEMENT_EXTENSIONS { get; }

        // // extern char *const OO_ELEMENT_DURATION;
        // [Field ("OO_ELEMENT_DURATION")]
        // unsafe sbyte* OO_ELEMENT_DURATION { get; }

        // // extern char *const OO_ELEMENT_TRACKING_EVENTS;
        // [Field ("OO_ELEMENT_TRACKING_EVENTS")]
        // unsafe sbyte* OO_ELEMENT_TRACKING_EVENTS { get; }

        // // extern char *const OO_ELEMENT_TRACKING;
        // [Field ("OO_ELEMENT_TRACKING")]
        // unsafe sbyte* OO_ELEMENT_TRACKING { get; }

        // // extern char *const OO_ELEMENT_AD_PARAMETERS;
        // [Field ("OO_ELEMENT_AD_PARAMETERS")]
        // unsafe sbyte* OO_ELEMENT_AD_PARAMETERS { get; }

        // // extern char *const OO_ELEMENT_VIDEO_CLICKS;
        // [Field ("OO_ELEMENT_VIDEO_CLICKS")]
        // unsafe sbyte* OO_ELEMENT_VIDEO_CLICKS { get; }

        // // extern char *const OO_ELEMENT_CLICK_THROUGH;
        // [Field ("OO_ELEMENT_CLICK_THROUGH")]
        // unsafe sbyte* OO_ELEMENT_CLICK_THROUGH { get; }

        // // extern char *const OO_ELEMENT_CLICK_TRACKING;
        // [Field ("OO_ELEMENT_CLICK_TRACKING")]
        // unsafe sbyte* OO_ELEMENT_CLICK_TRACKING { get; }

        // // extern char *const OO_ELEMENT_CUSTOM_CLICK;
        // [Field ("OO_ELEMENT_CUSTOM_CLICK")]
        // unsafe sbyte* OO_ELEMENT_CUSTOM_CLICK { get; }

        // // extern char *const OO_ELEMENT_MEDIA_FILES;
        // [Field ("OO_ELEMENT_MEDIA_FILES")]
        // unsafe sbyte* OO_ELEMENT_MEDIA_FILES { get; }

        // // extern char *const OO_ELEMENT_MEDIA_FILE;
        // [Field ("OO_ELEMENT_MEDIA_FILE")]
        // unsafe sbyte* OO_ELEMENT_MEDIA_FILE { get; }

        // // extern char *const OO_ELEMENT_VAST_AD_TAG_URI;
        // [Field ("OO_ELEMENT_VAST_AD_TAG_URI")]
        // unsafe sbyte* OO_ELEMENT_VAST_AD_TAG_URI { get; }

        // // extern char *const OO_ELEMENT_TT;
        // [Field ("OO_ELEMENT_TT")]
        // unsafe sbyte* OO_ELEMENT_TT { get; }

        // // extern char *const OO_ELEMENT_HEAD;
        // [Field ("OO_ELEMENT_HEAD")]
        // unsafe sbyte* OO_ELEMENT_HEAD { get; }

        // // extern char *const OO_ELEMENT_BODY;
        // [Field ("OO_ELEMENT_BODY")]
        // unsafe sbyte* OO_ELEMENT_BODY { get; }

        // // extern char *const OO_ELEMENT_STYLING;
        // [Field ("OO_ELEMENT_STYLING")]
        // unsafe sbyte* OO_ELEMENT_STYLING { get; }

        // // extern char *const OO_ELEMENT_STYLE;
        // [Field ("OO_ELEMENT_STYLE")]
        // unsafe sbyte* OO_ELEMENT_STYLE { get; }

        // // extern char *const OO_ELEMENT_DIV;
        // [Field ("OO_ELEMENT_DIV")]
        // unsafe sbyte* OO_ELEMENT_DIV { get; }

        // // extern char *const OO_ELEMENT_P;
        // [Field ("OO_ELEMENT_P")]
        // unsafe sbyte* OO_ELEMENT_P { get; }

        // // extern char *const OO_ELEMENT_SPAN;
        // [Field ("OO_ELEMENT_SPAN")]
        // unsafe sbyte* OO_ELEMENT_SPAN { get; }

        // // extern char *const OO_ELEMENT_METADATA;
        // [Field ("OO_ELEMENT_METADATA")]
        // unsafe sbyte* OO_ELEMENT_METADATA { get; }

        // // extern char *const OO_ELEMENT_BR;
        // [Field ("OO_ELEMENT_BR")]
        // unsafe sbyte* OO_ELEMENT_BR { get; }

        // // extern char *const OO_ELEMENT_ICONS;
        // [Field ("OO_ELEMENT_ICONS")]
        // unsafe sbyte* OO_ELEMENT_ICONS { get; }

        // // extern char *const OO_ELEMENT_ICON;
        // [Field ("OO_ELEMENT_ICON")]
        // unsafe sbyte* OO_ELEMENT_ICON { get; }

        // // extern char *const OO_ELEMENT_ICON_CLICKS;
        // [Field ("OO_ELEMENT_ICON_CLICKS")]
        // unsafe sbyte* OO_ELEMENT_ICON_CLICKS { get; }

        // // extern char *const OO_ELEMENT_ICON_CLICK_THROUGH;
        // [Field ("OO_ELEMENT_ICON_CLICK_THROUGH")]
        // unsafe sbyte* OO_ELEMENT_ICON_CLICK_THROUGH { get; }

        // // extern char *const OO_ELEMENT_ICON_CLICK_TRACKING;
        // [Field ("OO_ELEMENT_ICON_CLICK_TRACKING")]
        // unsafe sbyte* OO_ELEMENT_ICON_CLICK_TRACKING { get; }

        // // extern char *const OO_ELEMENT_ICON_VIEW_TRACKING;
        // [Field ("OO_ELEMENT_ICON_VIEW_TRACKING")]
        // unsafe sbyte* OO_ELEMENT_ICON_VIEW_TRACKING { get; }

        // // extern char *const OO_ELEMENT_STATIC_RESOURCE;
        // [Field ("OO_ELEMENT_STATIC_RESOURCE")]
        // unsafe sbyte* OO_ELEMENT_STATIC_RESOURCE { get; }

        // // extern char *const OO_ELEMENT_IFRAME_RESOURCE;
        // [Field ("OO_ELEMENT_IFRAME_RESOURCE")]
        // unsafe sbyte* OO_ELEMENT_IFRAME_RESOURCE { get; }

        // // extern char *const OO_ELEMENT_HTML_RESOURCE;
        // [Field ("OO_ELEMENT_HTML_RESOURCE")]
        // unsafe sbyte* OO_ELEMENT_HTML_RESOURCE { get; }

        // // extern char *const OO_ELEMENT_CREATIVE_ENTENSIONS;
        // [Field ("OO_ELEMENT_CREATIVE_ENTENSIONS")]
        // unsafe sbyte* OO_ELEMENT_CREATIVE_ENTENSIONS { get; }

        // // extern char *const OO_ELEMENT_CREATIVE_ENTENSION;
        // [Field ("OO_ELEMENT_CREATIVE_ENTENSION")]
        // unsafe sbyte* OO_ELEMENT_CREATIVE_ENTENSION { get; }

        // // extern char *const OO_ELEMENT_NONLINEAR_CLICK_TRACKING;
        // [Field ("OO_ELEMENT_NONLINEAR_CLICK_TRACKING")]
        // unsafe sbyte* OO_ELEMENT_NONLINEAR_CLICK_TRACKING { get; }

        // // extern char *const OO_ELEMENT_NONLINEAR_CLICK_THROUGH;
        // [Field ("OO_ELEMENT_NONLINEAR_CLICK_THROUGH")]
        // unsafe sbyte* OO_ELEMENT_NONLINEAR_CLICK_THROUGH { get; }

        // // extern char *const OO_ELEMENT_ALT_TEXT;
        // [Field ("OO_ELEMENT_ALT_TEXT")]
        // unsafe sbyte* OO_ELEMENT_ALT_TEXT { get; }

        // // extern char *const OO_ELEMENT_COMPANION_CLICK_THROUGH;
        // [Field ("OO_ELEMENT_COMPANION_CLICK_THROUGH")]
        // unsafe sbyte* OO_ELEMENT_COMPANION_CLICK_THROUGH { get; }

        // // extern char *const OO_ELEMENT_VMAP;
        // [Field ("OO_ELEMENT_VMAP")]
        // unsafe sbyte* OO_ELEMENT_VMAP { get; }

        // // extern char *const OO_ELEMENT_ADBREAK;
        // [Field ("OO_ELEMENT_ADBREAK")]
        // unsafe sbyte* OO_ELEMENT_ADBREAK { get; }

        // // extern char *const OO_ELEMENT_ADSOURCE;
        // [Field ("OO_ELEMENT_ADSOURCE")]
        // unsafe sbyte* OO_ELEMENT_ADSOURCE { get; }

        // // extern char *const OO_ELEMENT_ADTAGURI;
        // [Field ("OO_ELEMENT_ADTAGURI")]
        // unsafe sbyte* OO_ELEMENT_ADTAGURI { get; }

        // // extern char *const OO_ELEMENT_VASTADDATA;
        // [Field ("OO_ELEMENT_VASTADDATA")]
        // unsafe sbyte* OO_ELEMENT_VASTADDATA { get; }

        // // extern char *const OO_ELEMENT_CUSTOMADATA;
        // [Field ("OO_ELEMENT_CUSTOMADATA")]
        // unsafe sbyte* OO_ELEMENT_CUSTOMADATA { get; }

        // // extern NSString *const OO_ATTRIBUTE_VERSION;
        // [Field ("OO_ATTRIBUTE_VERSION")]
        // NSString OO_ATTRIBUTE_VERSION { get; }

        // // extern NSString *const OO_ATTRIBUTE_ID;
        // [Field ("OO_ATTRIBUTE_ID")]
        // NSString OO_ATTRIBUTE_ID { get; }

        // // extern NSString *const OO_ATTRIBUTE_ADID;
        // [Field ("OO_ATTRIBUTE_ADID")]
        // NSString OO_ATTRIBUTE_ADID { get; }

        // // extern NSString *const OO_ATTRIBUTE_SEQUENCE;
        // [Field ("OO_ATTRIBUTE_SEQUENCE")]
        // NSString OO_ATTRIBUTE_SEQUENCE { get; }

        // // extern NSString *const OO_ATTRIBUTE_EVENT;
        // [Field ("OO_ATTRIBUTE_EVENT")]
        // NSString OO_ATTRIBUTE_EVENT { get; }

        // // extern NSString *const OO_ATTRIBUTE_DELIVERY;
        // [Field ("OO_ATTRIBUTE_DELIVERY")]
        // NSString OO_ATTRIBUTE_DELIVERY { get; }

        // // extern NSString *const OO_ATTRIBUTE_SKIPOFFSET;
        // [Field ("OO_ATTRIBUTE_SKIPOFFSET")]
        // NSString OO_ATTRIBUTE_SKIPOFFSET { get; }

        // // extern NSString *const OO_ATTRIBUTE_TYPE;
        // [Field ("OO_ATTRIBUTE_TYPE")]
        // NSString OO_ATTRIBUTE_TYPE { get; }

        // // extern NSString *const OO_ATTRIBUTE_BITRATE;
        // [Field ("OO_ATTRIBUTE_BITRATE")]
        // NSString OO_ATTRIBUTE_BITRATE { get; }

        // // extern NSString *const OO_ATTRIBUTE_WIDTH;
        // [Field ("OO_ATTRIBUTE_WIDTH")]
        // NSString OO_ATTRIBUTE_WIDTH { get; }

        // // extern NSString *const OO_ATTRIBUTE_HEIGHT;
        // [Field ("OO_ATTRIBUTE_HEIGHT")]
        // NSString OO_ATTRIBUTE_HEIGHT { get; }

        // // extern NSString *const OO_ATTRIBUTE_SCALABLE;
        // [Field ("OO_ATTRIBUTE_SCALABLE")]
        // NSString OO_ATTRIBUTE_SCALABLE { get; }

        // // extern NSString *const OO_ATTRIBUTE_MAINTAIN_ASPECT_RATIO;
        // [Field ("OO_ATTRIBUTE_MAINTAIN_ASPECT_RATIO")]
        // NSString OO_ATTRIBUTE_MAINTAIN_ASPECT_RATIO { get; }

        // // extern NSString *const OO_ATTRIBUTE_API_FRAMEWORK;
        // [Field ("OO_ATTRIBUTE_API_FRAMEWORK")]
        // NSString OO_ATTRIBUTE_API_FRAMEWORK { get; }

        // // extern NSString *const OO_ATTRIBUTE_BEGIN;
        // [Field ("OO_ATTRIBUTE_BEGIN")]
        // NSString OO_ATTRIBUTE_BEGIN { get; }

        // // extern NSString *const OO_ATTRIBUTE_END;
        // [Field ("OO_ATTRIBUTE_END")]
        // NSString OO_ATTRIBUTE_END { get; }

        // // extern NSString *const OO_ATTRIBUTE_DUR;
        // [Field ("OO_ATTRIBUTE_DUR")]
        // NSString OO_ATTRIBUTE_DUR { get; }

        // // extern NSString *const OO_ATTRIBUTE_XML_LANG;
        // [Field ("OO_ATTRIBUTE_XML_LANG")]
        // NSString OO_ATTRIBUTE_XML_LANG { get; }

        // // extern NSString *const OO_ATTRIBUTE_PROGRAM;
        // [Field ("OO_ATTRIBUTE_PROGRAM")]
        // NSString OO_ATTRIBUTE_PROGRAM { get; }

        // // extern NSString *const OO_ATTRIBUTE_XPOSITION;
        // [Field ("OO_ATTRIBUTE_XPOSITION")]
        // NSString OO_ATTRIBUTE_XPOSITION { get; }

        // // extern NSString *const OO_ATTRIBUTE_YPOSITION;
        // [Field ("OO_ATTRIBUTE_YPOSITION")]
        // NSString OO_ATTRIBUTE_YPOSITION { get; }

        // // extern NSString *const OO_ATTRIBUTE_OFFSET;
        // [Field ("OO_ATTRIBUTE_OFFSET")]
        // NSString OO_ATTRIBUTE_OFFSET { get; }

        // // extern NSString *const OO_ATTRIBUTE_DURATEION;
        // [Field ("OO_ATTRIBUTE_DURATEION")]
        // NSString OO_ATTRIBUTE_DURATEION { get; }

        // // extern NSString *const OO_ATTRIBUTE_CREATIVE_TYPE;
        // [Field ("OO_ATTRIBUTE_CREATIVE_TYPE")]
        // NSString OO_ATTRIBUTE_CREATIVE_TYPE { get; }

        // // extern NSString *const OO_ATTRIBUTE_REQUIRED;
        // [Field ("OO_ATTRIBUTE_REQUIRED")]
        // NSString OO_ATTRIBUTE_REQUIRED { get; }

        // // extern NSString *const OO_ATTRIBUTE_EXPANDED_WIDTH;
        // [Field ("OO_ATTRIBUTE_EXPANDED_WIDTH")]
        // NSString OO_ATTRIBUTE_EXPANDED_WIDTH { get; }

        // // extern NSString *const OO_ATTRIBUTE_EXPANDED_HEIGHT;
        // [Field ("OO_ATTRIBUTE_EXPANDED_HEIGHT")]
        // NSString OO_ATTRIBUTE_EXPANDED_HEIGHT { get; }

        // // extern NSString *const OO_ATTRIBUTE_MIN_SUGGESTED_DURATION;
        // [Field ("OO_ATTRIBUTE_MIN_SUGGESTED_DURATION")]
        // NSString OO_ATTRIBUTE_MIN_SUGGESTED_DURATION { get; }

        // // extern NSString *const OO_ATTRIBUTE_ASSET_WIDTH;
        // [Field ("OO_ATTRIBUTE_ASSET_WIDTH")]
        // NSString OO_ATTRIBUTE_ASSET_WIDTH { get; }

        // // extern NSString *const OO_ATTRIBUTE_ASSET_HEIGHT;
        // [Field ("OO_ATTRIBUTE_ASSET_HEIGHT")]
        // NSString OO_ATTRIBUTE_ASSET_HEIGHT { get; }

        // // extern NSString *const OO_ATTRIBUTE_AD_SLOT_ID;
        // [Field ("OO_ATTRIBUTE_AD_SLOT_ID")]
        // NSString OO_ATTRIBUTE_AD_SLOT_ID { get; }

        // // extern NSString *const OO_ATTRIBUTE_TIMEOFFSET;
        // [Field ("OO_ATTRIBUTE_TIMEOFFSET")]
        // NSString OO_ATTRIBUTE_TIMEOFFSET { get; }

        // // extern NSString *const OO_ATTRIBUTE_BREAKTYPE;
        // [Field ("OO_ATTRIBUTE_BREAKTYPE")]
        // NSString OO_ATTRIBUTE_BREAKTYPE { get; }

        // // extern NSString *const OO_ATTRIBUTE_BREAKID;
        // [Field ("OO_ATTRIBUTE_BREAKID")]
        // NSString OO_ATTRIBUTE_BREAKID { get; }

        // // extern NSString *const OO_ATTRIBUTE_REPEAT_AFTER;
        // [Field ("OO_ATTRIBUTE_REPEAT_AFTER")]
        // NSString OO_ATTRIBUTE_REPEAT_AFTER { get; }

        // // extern NSString *const OO_ATTRIBUTE_ALLOW_MULTIPLE_ADS;
        // [Field ("OO_ATTRIBUTE_ALLOW_MULTIPLE_ADS")]
        // NSString OO_ATTRIBUTE_ALLOW_MULTIPLE_ADS { get; }

        // // extern NSString *const OO_ATTRIBUTE_FOLLOW_REDIRECTS;
        // [Field ("OO_ATTRIBUTE_FOLLOW_REDIRECTS")]
        // NSString OO_ATTRIBUTE_FOLLOW_REDIRECTS { get; }

        // // extern NSString *const OO_ATTRIBUTE_TEMPLATE_TYPE;
        // [Field ("OO_ATTRIBUTE_TEMPLATE_TYPE")]
        // NSString OO_ATTRIBUTE_TEMPLATE_TYPE { get; }

        // // extern NSString *const OO_MIME_TYPE_MP4;
        // [Field ("OO_MIME_TYPE_MP4")]
        // NSString OO_MIME_TYPE_MP4 { get; }

        // // extern NSString *const OO_MIME_TYPE_M3U8;
        // [Field ("OO_MIME_TYPE_M3U8")]
        // NSString OO_MIME_TYPE_M3U8 { get; }

        // // extern NSString *const OO_TAG_START;
        // [Field ("OO_TAG_START")]
        // NSString OO_TAG_START { get; }

        // // extern NSString *const OO_TAG_FIRST_QUARTILE;
        // [Field ("OO_TAG_FIRST_QUARTILE")]
        // NSString OO_TAG_FIRST_QUARTILE { get; }

        // // extern NSString *const OO_TAG_MIDPOINT;
        // [Field ("OO_TAG_MIDPOINT")]
        // NSString OO_TAG_MIDPOINT { get; }

        // // extern NSString *const OO_TAG_THIRD_QUARTILE;
        // [Field ("OO_TAG_THIRD_QUARTILE")]
        // NSString OO_TAG_THIRD_QUARTILE { get; }

        // // extern NSString *const OO_TAG_COMPLETE;
        // [Field ("OO_TAG_COMPLETE")]
        // NSString OO_TAG_COMPLETE { get; }

        // // extern NSString *const OO_TAG_MUTE;
        // [Field ("OO_TAG_MUTE")]
        // NSString OO_TAG_MUTE { get; }

        // // extern NSString *const OO_TAG_UNMUTE;
        // [Field ("OO_TAG_UNMUTE")]
        // NSString OO_TAG_UNMUTE { get; }

        // // extern NSString *const OO_TAG_PAUSE;
        // [Field ("OO_TAG_PAUSE")]
        // NSString OO_TAG_PAUSE { get; }

        // // extern NSString *const OO_TAG_RESUME;
        // [Field ("OO_TAG_RESUME")]
        // NSString OO_TAG_RESUME { get; }

        // // extern NSString *const OO_TAG_FULLSCREEN;
        // [Field ("OO_TAG_FULLSCREEN")]
        // NSString OO_TAG_FULLSCREEN { get; }

        // // extern NSString *const OO_TAG_EXIT_FULLSCREEN;
        // [Field ("OO_TAG_EXIT_FULLSCREEN")]
        // NSString OO_TAG_EXIT_FULLSCREEN { get; }

        // // extern NSString *const OO_TAG_SKIP;
        // [Field ("OO_TAG_SKIP")]
        // NSString OO_TAG_SKIP { get; }

        // // extern NSString *const OO_TAG_REWIND;
        // [Field ("OO_TAG_REWIND")]
        // NSString OO_TAG_REWIND { get; }

        // // extern NSString *const OO_TAG_CLOSE_LINEAR;
        // [Field ("OO_TAG_CLOSE_LINEAR")]
        // NSString OO_TAG_CLOSE_LINEAR { get; }

        // // extern NSString *const OO_TAG_CLICK_THROUGH;
        // [Field ("OO_TAG_CLICK_THROUGH")]
        // NSString OO_TAG_CLICK_THROUGH { get; }

        // // extern const NSInteger OO_ERROR_XML_PARSE;
        // [Field ("OO_ERROR_XML_PARSE")]
        // nint OO_ERROR_XML_PARSE { get; }

        // // extern const NSInteger OO_ERROR_VAST_SCHEMA;
        // [Field ("OO_ERROR_VAST_SCHEMA")]
        // nint OO_ERROR_VAST_SCHEMA { get; }

        // // extern const NSInteger OO_ERROR_VAST_VERSION;
        // [Field ("OO_ERROR_VAST_VERSION")]
        // nint OO_ERROR_VAST_VERSION { get; }

        // // extern const NSInteger OO_ERROR_GENERAL_WRAPPER;
        // [Field ("OO_ERROR_GENERAL_WRAPPER")]
        // nint OO_ERROR_GENERAL_WRAPPER { get; }

        // // extern const NSInteger OO_ERROR_WRAPPER_LIMIT;
        // [Field ("OO_ERROR_WRAPPER_LIMIT")]
        // nint OO_ERROR_WRAPPER_LIMIT { get; }

        // // extern const NSInteger OO_ERROR_VAST_RESPONSE_WRAPPER;
        // [Field ("OO_ERROR_VAST_RESPONSE_WRAPPER")]
        // nint OO_ERROR_VAST_RESPONSE_WRAPPER { get; }

        // // extern const NSInteger OO_ERROR_GENERAL_LINEAR;
        // [Field ("OO_ERROR_GENERAL_LINEAR")]
        // nint OO_ERROR_GENERAL_LINEAR { get; }

        // // extern const NSInteger OO_ERROR_GENERAL_NONLINEAR_ADS;
        // [Field ("OO_ERROR_GENERAL_NONLINEAR_ADS")]
        // nint OO_ERROR_GENERAL_NONLINEAR_ADS { get; }

        // // extern const NSInteger OO_ERROR_LINEAR_FILE_NOT_FOUND;
        // [Field ("OO_ERROR_LINEAR_FILE_NOT_FOUND")]
        // nint OO_ERROR_LINEAR_FILE_NOT_FOUND { get; }

        // // extern const NSInteger OO_ERROR_LINEAR_TIMEOUT_MEDIAFILE;
        // [Field ("OO_ERROR_LINEAR_TIMEOUT_MEDIAFILE")]
        // nint OO_ERROR_LINEAR_TIMEOUT_MEDIAFILE { get; }

        // // extern const NSInteger OO_ERROR_LINEAR_SUPPORTED_MEDIA_NOT_FOUND;
        // [Field ("OO_ERROR_LINEAR_SUPPORTED_MEDIA_NOT_FOUND")]
        // nint OO_ERROR_LINEAR_SUPPORTED_MEDIA_NOT_FOUND { get; }
    }

    // @interface OOTBXML : NSObject
    [BaseType(typeof(NSObject))]
    interface OOTBXML
    {
        //HACK
        // @property (readonly, nonatomic) OOTBXMLElement * rootXMLElement;
        // [Export ("rootXMLElement")]
        // unsafe OOTBXMLElement* RootXMLElement { get; }

        // +(id)tbxmlWithURL:(NSURL *)aURL;
        [Static]
        [Export("tbxmlWithURL:")]
        NSObject TbxmlWithURL(NSUrl aURL);

        // +(id)tbxmlWithURL:(NSURL *)aURL ignoredTags:(NSArray *)theIgnoredTags;
        [Static]
        [Export("tbxmlWithURL:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject TbxmlWithURL(NSUrl aURL, NSObject[] theIgnoredTags);

        // +(id)tbxmlWithXMLString:(NSString *)aXMLString;
        [Static]
        [Export("tbxmlWithXMLString:")]
        NSObject TbxmlWithXMLString(string aXMLString);

        // +(id)tbxmlWithXMLString:(NSString *)aXMLString ignoredTags:(NSArray *)theIgnoredTags;
        [Static]
        [Export("tbxmlWithXMLString:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject TbxmlWithXMLString(string aXMLString, NSObject[] theIgnoredTags);

        // +(id)tbxmlWithXMLData:(NSData *)aData;
        [Static]
        [Export("tbxmlWithXMLData:")]
        NSObject TbxmlWithXMLData(NSData aData);

        // +(id)tbxmlWithXMLData:(NSData *)aData ignoredTags:(NSArray *)theIgnoredTags;
        [Static]
        [Export("tbxmlWithXMLData:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject TbxmlWithXMLData(NSData aData, NSObject[] theIgnoredTags);

        // +(id)tbxmlWithXMLFile:(NSString *)aXMLFile;
        [Static]
        [Export("tbxmlWithXMLFile:")]
        NSObject TbxmlWithXMLFile(string aXMLFile);

        // +(id)tbxmlWithXMLFile:(NSString *)aXMLFile ignoredTags:(NSArray *)theIgnoredTags;
        [Static]
        [Export("tbxmlWithXMLFile:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject TbxmlWithXMLFile(string aXMLFile, NSObject[] theIgnoredTags);

        // +(id)tbxmlWithXMLFile:(NSString *)aXMLFile fileExtension:(NSString *)aFileExtension;
        [Static]
        [Export("tbxmlWithXMLFile:fileExtension:")]
        NSObject TbxmlWithXMLFile(string aXMLFile, string aFileExtension);

        // +(id)tbxmlWithXMLFile:(NSString *)aXMLFile fileExtension:(NSString *)aFileExtension ignoredTags:(NSArray *)theIgnoredTags;
        [Static]
        [Export("tbxmlWithXMLFile:fileExtension:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject TbxmlWithXMLFile(string aXMLFile, string aFileExtension, NSObject[] theIgnoredTags);

        // -(id)initWithURL:(NSURL *)aURL;
        [Export("initWithURL:")]
        IntPtr Constructor(NSUrl aURL);

        // -(id)initWithURL:(NSURL *)aURL ignoredTags:(NSArray *)theIgnoredTags;
        [Export("initWithURL:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSUrl aURL, NSObject[] theIgnoredTags);

        // -(id)initWithXMLString:(NSString *)aXMLString;
        [Export("initWithXMLString:")]
        IntPtr Constructor(string aXMLString);

        // -(id)initWithXMLString:(NSString *)aXMLString ignoredTags:(NSArray *)theIgnoredTags;
        [Export("initWithXMLString:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(string aXMLString, NSObject[] theIgnoredTags);

        // -(id)initWithXMLData:(NSData *)aData;
        [Export("initWithXMLData:")]
        IntPtr Constructor(NSData aData);

        // -(id)initWithXMLData:(NSData *)aData ignoredTags:(NSArray *)theIgnoredTags;
        [Export("initWithXMLData:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSData aData, NSObject[] theIgnoredTags);

        // -(id)initWithXMLFile:(NSString *)aXMLFile;
        //[Export("initWithXMLFile:")]
        //IntPtr Constructor(string aXMLFile);

        // -(id)initWithXMLFile:(NSString *)aXMLFile ignoredTags:(NSArray *)theIgnoredTags;
        //[Export("initWithXMLFile:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        //IntPtr Constructor(string aXMLFile, NSObject[] theIgnoredTags);

        // -(id)initWithXMLFile:(NSString *)aXMLFile fileExtension:(NSString *)aFileExtension;
        [Export("initWithXMLFile:fileExtension:")]
        IntPtr Constructor(string aXMLFile, string aFileExtension);

        // -(id)initWithXMLFile:(NSString *)aXMLFile fileExtension:(NSString *)aFileExtension ignoredTags:(NSArray *)theIgnoredTags;
        [Export("initWithXMLFile:fileExtension:ignoredTags:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(string aXMLFile, string aFileExtension, NSObject[] theIgnoredTags);
    }

    //HACK
    // // @interface StaticFunctions (OOTBXML)
    // [Category]
    // [BaseType (typeof(OOTBXML))]
    // interface OOTBXML_StaticFunctions
    // {
    //  // +(NSString *)elementName:(OOTBXMLElement *)aXMLElement;
    //  [Static]
    //  [Export ("elementName:")]
    //  unsafe string ElementName (OOTBXMLElement* aXMLElement);

    //  // +(NSString *)textForElement:(OOTBXMLElement *)aXMLElement;
    //  [Static]
    //  [Export ("textForElement:")]
    //  unsafe string TextForElement (OOTBXMLElement* aXMLElement);

    //  // +(NSString *)valueOfAttributeNamed:(NSString *)aName forElement:(OOTBXMLElement *)aXMLElement;
    //  [Static]
    //  [Export ("valueOfAttributeNamed:forElement:")]
    //  unsafe string ValueOfAttributeNamed (string aName, OOTBXMLElement* aXMLElement);

    //  // +(NSString *)attributeName:(OOTBXMLAttribute *)aXMLAttribute;
    //  [Static]
    //  [Export ("attributeName:")]
    //  unsafe string AttributeName (OOTBXMLAttribute* aXMLAttribute);

    //  // +(NSString *)attributeValue:(OOTBXMLAttribute *)aXMLAttribute;
    //  [Static]
    //  [Export ("attributeValue:")]
    //  unsafe string AttributeValue (OOTBXMLAttribute* aXMLAttribute);

    //  // +(OOTBXMLElement *)nextSiblingNamed:(NSString *)aName searchFromElement:(OOTBXMLElement *)aXMLElement;
    //  [Static]
    //  [Export ("nextSiblingNamed:searchFromElement:")]
    //  unsafe OOTBXMLElement* NextSiblingNamed (string aName, OOTBXMLElement* aXMLElement);

    //  // +(OOTBXMLElement *)childElementNamed:(NSString *)aName parentElement:(OOTBXMLElement *)aParentXMLElement;
    //  [Static]
    //  [Export ("childElementNamed:parentElement:")]
    //  unsafe OOTBXMLElement* ChildElementNamed (string aName, OOTBXMLElement* aParentXMLElement);
    // }

    // @protocol OOPlayableItem <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOPlayableItem
    {
        // @required -(NSArray *)getStreams;
        [Abstract]
        [Export("getStreams")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        //HACK
          NSMutableArray Streams { get; }
        //NSObject[] Streams { get; }
    }

    // @interface OOVASTLinearAd : NSObject <OOPlayableItem>
    [BaseType(typeof(NSObject))]
    interface OOVASTLinearAd : OOPlayableItem
    {
        // @property (readonly, nonatomic) NSMutableArray * icons;
        [Export("icons")]
        NSMutableArray Icons { get; }

        // @property (readonly, nonatomic) Float64 skipoffset;
        [Export("skipoffset")]
        double Skipoffset { get; }

        // @property (readonly, nonatomic) Float64 duration;
        [Export("duration")]
        double Duration { get; }

        // @property (readonly, nonatomic, strong) NSMutableDictionary * trackingEvents;
        [Export("trackingEvents", ArgumentSemantic.Strong)]
        NSMutableDictionary TrackingEvents { get; }

        // @property (readonly, nonatomic, strong) NSString * parameters;
        [Export("parameters", ArgumentSemantic.Strong)]
        string Parameters { get; }

        // @property (readonly, nonatomic, strong) NSString * clickThroughURL;
        [Export("clickThroughURL", ArgumentSemantic.Strong)]
        string ClickThroughURL { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * clickTrackingURLs;
        [Export("clickTrackingURLs", ArgumentSemantic.Strong)]
        NSMutableArray ClickTrackingURLs { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * customClickURLs;
        [Export("customClickURLs", ArgumentSemantic.Strong)]
        NSMutableArray CustomClickURLs { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * streams;
        [Export("streams", ArgumentSemantic.Strong)]
        NSMutableArray Streams { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * errorCodes;
        [Export("errorCodes", ArgumentSemantic.Strong)]
        NSMutableArray ErrorCodes { get; }

        // // -(id)initWithXML:(OOTBXMLElement *)xml;
        // [Export ("initWithXML:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* xml);

        // -(void)updateTrackingEvents:(NSMutableDictionary *)newTrackingEvents;
        [Export("updateTrackingEvents:")]
        void UpdateTrackingEvents(NSMutableDictionary newTrackingEvents);

        // -(void)updateClickTrackingURLs:(NSMutableArray *)newClickTrackingURLs;
        [Export("updateClickTrackingURLs:")]
        void UpdateClickTrackingURLs(NSMutableArray newClickTrackingURLs);

        // -(void)merge:(OOVASTLinearAd *)linear;
        [Export("merge:")]
        void Merge(OOVASTLinearAd linear);
    }

    // @interface OOVASTCompanionAds : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTCompanionAds
    {
        // // -(id)initWithElement:(OOTBXMLElement *)element;
        // [Export ("initWithElement:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* element);

        // @property (readonly, nonatomic) RequiredType required;
        [Export("required")]
        RequiredType Required { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * companions;
        [Export("companions", ArgumentSemantic.Strong)]
        NSMutableArray Companions { get; }
    }

    // @interface OOVASTNonLinearAds : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTNonLinearAds
    {
        // @property (readonly, nonatomic, strong) NSMutableDictionary * trackingEvents;
        [Export("trackingEvents", ArgumentSemantic.Strong)]
        NSMutableDictionary TrackingEvents { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * nonLinears;
        [Export("nonLinears", ArgumentSemantic.Strong)]
        NSMutableArray NonLinears { get; }

        // // -(id)initWithElement:(OOTBXMLElement *)element;
        // [Export ("initWithElement:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* element);
    }

    // @interface OOVASTCreative : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTCreative
    {
        // @property (readonly, nonatomic) NSInteger sequence;
        [Export("sequence")]
        nint Sequence { get; }

        // @property (readonly, nonatomic, strong) NSString * id;
        [Export("id", ArgumentSemantic.Strong)]
        string Id { get; }

        // @property (readonly, nonatomic, strong) NSString * adId;
        [Export("adId", ArgumentSemantic.Strong)]
        string AdId { get; }

        // @property (readonly, nonatomic, strong) OOVASTLinearAd * linear;
        [Export("linear", ArgumentSemantic.Strong)]
        OOVASTLinearAd Linear { get; }

        // @property (readonly, nonatomic, strong) OOVASTCompanionAds * companionAds;
        [Export("companionAds", ArgumentSemantic.Strong)]
        OOVASTCompanionAds CompanionAds { get; }

        // @property (readonly, nonatomic, strong) OOVASTNonLinearAds * nonLinearAds;
        [Export("nonLinearAds", ArgumentSemantic.Strong)]
        OOVASTNonLinearAds NonLinearAds { get; }

        // // -(id)initWithElement:(OOTBXMLElement *)element;
        // [Export ("initWithElement:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* element);

        // -(BOOL)hasLinear;
        [Export("hasLinear")]
        //[Verify(MethodToProperty)]
        bool HasLinear { get; }

        // -(BOOL)hasCompanionAds;
        [Export("hasCompanionAds")]
        //[Verify(MethodToProperty)]
        bool HasCompanionAds { get; }

        // -(BOOL)hasNonLinearAds;
        [Export("hasNonLinearAds")]
        // [Verify (MethodToProperty)]
        bool HasNonLinearAds { get; }
    }

    // @interface OOVASTVMAPAdHelper : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTVMAPAdHelper
    {
        // // +(BOOL)parse:(OOTBXMLElement *)e adSpots:(NSMutableArray *)adSpots duration:(NSInteger)duration;
        // [Static]
        // [Export ("parse:adSpots:duration:")]
        // unsafe bool Parse (OOTBXMLElement* e, NSMutableArray adSpots, nint duration);

        // // +(OOTBXMLElement *)firstElement:(OOTBXMLElement *)e byName:(NSString *)name;
        // [Static]
        // [Export ("firstElement:byName:")]
        // unsafe OOTBXMLElement* FirstElement (OOTBXMLElement* e, string name);
    }

    // @interface OOVASTOffset : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTOffset
    {
        // @property (readonly, assign, nonatomic) OffsetType type;
        [Export("type", ArgumentSemantic.Assign)]
        OffsetType Type { get; }

        // -(id)initWithType:(OffsetType)type value:(Float64)value;
        [Export("initWithType:value:")]
        IntPtr Constructor(OffsetType type, double value);

        // -(id)initWithOffset:(NSString *)offsetStr;
        [Export("initWithOffset:")]
        IntPtr Constructor(string offsetStr);

        // -(Float64)getPercentage;
        [Export("getPercentage")]
        //[Verify(MethodToProperty)]
        double Percentage { get; }

        // -(Float64)getSeconds;
        [Export("getSeconds")]
        //[Verify(MethodToProperty)]
        double Seconds { get; }

        // -(NSInteger)getPosition;
        [Export("getPosition")]
        //[Verify(MethodToProperty)]
        nint Position { get; }
    }

    // @interface OOVASTResource : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTResource
    {
        // @property (readonly, nonatomic) OOType type;
        [Export("type")]
        OOType Type { get; }

        // @property (readonly, nonatomic, strong) NSString * uri;
        [Export("uri", ArgumentSemantic.Strong)]
        string Uri { get; }

        // @property (readonly, nonatomic, strong) NSString * mimeType;
        [Export("mimeType", ArgumentSemantic.Strong)]
        string MimeType { get; }

        // -(id)initWithType:(Type)type mimeType:(NSString *)mimeType uri:(NSString *)uri;
        [Export("initWithType:mimeType:uri:")]
        IntPtr Constructor(OOType type, string mimeType, string uri);

        // -(NSString *)typeToStr:(Type)type;
        [Export("typeToStr:")]
        string TypeToStr(OOType type);
    }

    // @interface OOVASTIcon : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTIcon
    {
        // @property (readonly, nonatomic, strong) NSString * program;
        [Export("program", ArgumentSemantic.Strong)]
        string Program { get; }

        // @property (readonly, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; }

        // @property (readonly, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; }

        // @property (readonly, nonatomic) NSInteger xPosition;
        [Export("xPosition")]
        nint XPosition { get; }

        // @property (readonly, nonatomic) NSInteger yPosition;
        [Export("yPosition")]
        nint YPosition { get; }

        // @property (readonly, nonatomic) Float64 duration;
        [Export("duration")]
        double Duration { get; }

        // @property (readonly, nonatomic) Float64 offset;
        [Export("offset")]
        double Offset { get; }

        // @property (readonly, nonatomic, strong) NSString * resourceUrl;
        [Export("resourceUrl", ArgumentSemantic.Strong)]
        string ResourceUrl { get; }

        // @property (readonly, nonatomic, strong) NSString * creativeType;
        [Export("creativeType", ArgumentSemantic.Strong)]
        string CreativeType { get; }

        // @property (readonly, assign, nonatomic) ResourceType type;
        [Export("type", ArgumentSemantic.Assign)]
        ResourceType Type { get; }

        // @property (readonly, nonatomic, strong) NSString * apiFramework;
        [Export("apiFramework", ArgumentSemantic.Strong)]
        string ApiFramework { get; }

        // @property (readonly, nonatomic, strong) NSString * clickThrough;
        [Export("clickThrough", ArgumentSemantic.Strong)]
        string ClickThrough { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * clickTrackings;
        [Export("clickTrackings", ArgumentSemantic.Strong)]
        NSMutableArray ClickTrackings { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * viewTrackings;
        [Export("viewTrackings", ArgumentSemantic.Strong)]
        NSMutableArray ViewTrackings { get; }

        // // -(id)initWithXML:(OOTBXMLElement *)xml;
        // [Export ("initWithXML:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* xml);
    }

    // @interface OOVASTNonLinear : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTNonLinear
    {
        // @property (readonly, nonatomic, strong) NSString * id;
        [Export("id", ArgumentSemantic.Strong)]
        string Id { get; }

        // @property (readonly, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; }

        // @property (readonly, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; }

        // @property (readonly, nonatomic) NSInteger expandedWidth;
        [Export("expandedWidth")]
        nint ExpandedWidth { get; }

        // @property (readonly, nonatomic) NSInteger expandedHeight;
        [Export("expandedHeight")]
        nint ExpandedHeight { get; }

        // @property (readonly, nonatomic) BOOL scalable;
        [Export("scalable")]
        bool Scalable { get; }

        // @property (readonly, nonatomic) BOOL maintainAspectRatio;
        [Export("maintainAspectRatio")]
        bool MaintainAspectRatio { get; }

        // @property (readonly, nonatomic) NSInteger minSuggestedDuration;
        [Export("minSuggestedDuration")]
        nint MinSuggestedDuration { get; }

        // @property (readonly, nonatomic, strong) NSString * apiFramework;
        [Export("apiFramework", ArgumentSemantic.Strong)]
        string ApiFramework { get; }

        // @property (readonly, nonatomic, strong) OOVASTResource * resource;
        [Export("resource", ArgumentSemantic.Strong)]
        OOVASTResource Resource { get; }

        // @property (readonly, nonatomic, strong) NSMutableArray * clickTrackings;
        [Export("clickTrackings", ArgumentSemantic.Strong)]
        NSMutableArray ClickTrackings { get; }

        // @property (readonly, nonatomic, strong) NSString * clickThrough;
        [Export("clickThrough", ArgumentSemantic.Strong)]
        string ClickThrough { get; }

        // // @property (readonly, nonatomic) OOTBXMLElement * creativeExtensions;
        // [Export ("creativeExtensions")]
        // unsafe OOTBXMLElement* CreativeExtensions { get; }

        // @property (readonly, nonatomic, strong) NSString * parameters;
        [Export("parameters", ArgumentSemantic.Strong)]
        string Parameters { get; }

        // // -(id)initWithElement:(OOTBXMLElement *)element;
        // [Export ("initWithElement:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* element);
    }

    // @interface OOVASTCompanion : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTCompanion
    {
        // @property (readonly, nonatomic) NSString * id;
        [Export("id")]
        string Id { get; }

        // @property (readonly, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; }

        // @property (readonly, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; }

        // @property (readonly, nonatomic) NSInteger assetWidth;
        [Export("assetWidth")]
        nint AssetWidth { get; }

        // @property (readonly, nonatomic) NSInteger assetHeight;
        [Export("assetHeight")]
        nint AssetHeight { get; }

        // @property (readonly, nonatomic) NSInteger expandedWidth;
        [Export("expandedWidth")]
        nint ExpandedWidth { get; }

        // @property (readonly, nonatomic) NSInteger expandedHeight;
        [Export("expandedHeight")]
        nint ExpandedHeight { get; }

        // @property (readonly, nonatomic) NSString * apiFramework;
        [Export("apiFramework")]
        string ApiFramework { get; }

        // @property (readonly, nonatomic) NSString * adSlotId;
        [Export("adSlotId")]
        string AdSlotId { get; }

        // @property (readonly, nonatomic) OOVASTResource * resource;
        [Export("resource")]
        OOVASTResource Resource { get; }

        // @property (readonly, nonatomic) NSMutableDictionary * trackingEvents;
        [Export("trackingEvents")]
        NSMutableDictionary TrackingEvents { get; }

        // @property (readonly, nonatomic) NSString * clickThrough;
        [Export("clickThrough")]
        string ClickThrough { get; }

        // // @property (readonly, nonatomic) OOTBXMLElement * creativeExtensions;
        // [Export ("creativeExtensions")]
        // unsafe OOTBXMLElement* CreativeExtensions { get; }

        // @property (readonly, nonatomic) NSString * parameters;
        [Export("parameters")]
        string Parameters { get; }

        // // -(id)initWithElement:(OOTBXMLElement *)element;
        // [Export ("initWithElement:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* element);
    }

    // @interface OOAdSpot : NSObject
    [BaseType(typeof(NSObject))]
    interface OOAdSpot
    {
        // @property NSNumber * time;
        [Export("time", ArgumentSemantic.Assign)]
        NSNumber Time { get; set; }

        // @property int priority;
        [Export("priority")]
        int Priority { get; set; }

        // -(instancetype)initWithTime:(NSNumber *)time;
        [Export("initWithTime:")]
        IntPtr Constructor(NSNumber time);

        // -(NSComparisonResult)compare:(OOAdSpot *)other;
        [Export("compare:")]
        NSComparisonResult Compare(OOAdSpot other);
    }

    // @interface OOManagedAdSpot : OOAdSpot
    [BaseType(typeof(OOAdSpot))]
    interface OOManagedAdSpot
    {
        // @property (readonly) NSURL * clickURL;
        [Export("clickURL")]
        NSUrl ClickURL { get; }

        // @property (readonly) NSArray * trackingURLs;
        [Export("trackingURLs")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] TrackingURLs { get; }

        // +(OOManagedAdSpot *)adSpotFromDictionary:(NSDictionary *)data api:(OOPlayerAPIClient *)api duration:(Float64)duration;
        [Static]
        [Export("adSpotFromDictionary:api:duration:")]
        OOManagedAdSpot AdSpotFromDictionary(NSDictionary data, OOOoyalaAPIClient api, double duration);
    }

    // @interface OOVASTAdSpot : OOManagedAdSpot
    [BaseType(typeof(OOManagedAdSpot))]
    interface OOVASTAdSpot
    {
        // @property (readonly, nonatomic) NSString * signature;
        [Export("signature")]
        string Signature { get; }

        // @property (readonly, nonatomic) NSInteger expires;
        [Export("expires")]
        nint Expires { get; }

        // @property (readonly, nonatomic) NSURL * vastURL;
        [Export("vastURL")]
        NSUrl VastURL { get; }

        // @property (readonly, nonatomic) NSMutableArray * ads;
        [Export("ads")]
        NSMutableArray Ads { get; }

        // @property (readonly, nonatomic) NSMutableArray * vmapAdSpots;
        [Export("vmapAdSpots")]
        NSMutableArray VmapAdSpots { get; }

        // @property (readonly, nonatomic) NSInteger contentDuration;
        [Export("contentDuration")]
        nint ContentDuration { get; }

        // @property (readonly, nonatomic) NSMutableDictionary * errors;
        [Export("errors")]
        NSMutableDictionary Errors { get; }

        //// // -(instancetype)initWithOffset:(NSInteger)timeoffset duration:(NSInteger)duration element:(OOTBXMLElement *)e;
         //[Export ("initWithOffset:duration:element:")]
         //unsafe IntPtr Constructor (nint timeoffset, nint duration, OOTBXMLElement* e);

        // -(instancetype)initWithTime:(NSNumber *)theTime duration:(NSInteger)duration clickURL:(NSURL *)theClickURL trackingURLs:(NSArray *)theTrackingURLs vastURL:(NSURL *)theVASTURL;
        [Export("initWithTime:duration:clickURL:trackingURLs:vastURL:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSNumber theTime, nint duration, NSUrl theClickURL, NSObject[] theTrackingURLs, NSUrl theVASTURL);

        // -(instancetype)initWithDictionary:(NSDictionary *)data api:(OOPlayerAPIClient *)theAPI duration:(NSInteger)duration;
        [Export("initWithDictionary:api:duration:")]
        IntPtr Constructor(NSDictionary data, OOOoyalaAPIClient theAPI, nint duration);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(BOOL)fetchPlaybackInfo;
        [Export("fetchPlaybackInfo")]
        //[Verify(MethodToProperty)]
        bool FetchPlaybackInfo { get; }
    }

    // @interface OOVASTVMAPAdSpot : OOVASTAdSpot
    [BaseType(typeof(OOVASTAdSpot))]
    interface OOVASTVMAPAdSpot
    {
        // @property (readonly, nonatomic) OOVASTOffset * timeOffset;
        [Export("timeOffset")]
        OOVASTOffset TimeOffset { get; }

        // @property (readonly, nonatomic) NSString * breakType;
        [Export("breakType")]
        string BreakType { get; }

        // @property (readonly, nonatomic) NSString * breakId;
        [Export("breakId")]
        string BreakId { get; }

        // @property (readonly, nonatomic) NSString * adSourceId;
        [Export("adSourceId")]
        string AdSourceId { get; }

        // @property (readonly, nonatomic) BOOL allowMultipleAds;
        [Export("allowMultipleAds")]
        bool AllowMultipleAds { get; }

        // @property (readonly, nonatomic) BOOL followRedirects;
        [Export("followRedirects")]
        bool FollowRedirects { get; }

        // -(instancetype)initWithOffset:(OOVASTOffset *)timeOffset duration:(NSInteger)duration repeatAfter:(Float64)repeatAfter breakType:(NSString *)breakType breakId:(NSString *)breakId sourceId:(NSString *)sourceId allowMultipleAds:(BOOL)allowMultipleAds followRedirects:(BOOL)followRedirects element:(OOTBXMLElement *)element;
        // [Export ("initWithOffset:duration:repeatAfter:breakType:breakId:sourceId:allowMultipleAds:followRedirects:element:")]
        // unsafe IntPtr Constructor (OOVASTOffset timeOffset, nint duration, double repeatAfter, string breakType, string breakId, string sourceId, bool allowMultipleAds, bool followRedirects, OOTBXMLElement* element);

        // -(instancetype)initWithOffset:(OOVASTOffset *)timeOffset duration:(NSInteger)duration repeatAfter:(Float64)repeatAfter breakType:(NSString *)breakType breakId:(NSString *)breakId sourceId:(NSString *)sourceId allowMultipleAds:(BOOL)allowMultipleAds followRedirects:(BOOL)followRedirects vastUrl:(NSURL *)vastUrl;
        [Export("initWithOffset:duration:repeatAfter:breakType:breakId:sourceId:allowMultipleAds:followRedirects:vastUrl:")]
        IntPtr Constructor(OOVASTOffset timeOffset, nint duration, double repeatAfter, string breakType, string breakId, string sourceId, bool allowMultipleAds, bool followRedirects, NSUrl vastUrl);

        // -(BOOL)isRepeatable;
        [Export("isRepeatable")]
        //[Verify(MethodToProperty)]
        bool IsRepeatable { get; }

        // -(void)markAsPlayed;
        [Export("markAsPlayed")]
        void MarkAsPlayed();

        // -(void)markAsUnplayed;
        [Export("markAsUnplayed")]
        void MarkAsUnplayed();
    }

    // @interface OOVASTAd : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface OOVASTAd
    {
        // @property (readonly, nonatomic) NSString * adID;
        [Export("adID")]
        string AdID { get; }

        // @property (nonatomic) NSInteger adSequence;
        [Export("adSequence")]
        nint AdSequence { get; set; }

        // @property (readonly, nonatomic) NSString * system;
        [Export("system")]
        string System { get; }

        // @property (readonly, nonatomic) NSString * systemVersion;
        [Export("systemVersion")]
        string SystemVersion { get; }

        // @property (readonly, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) NSString * adDescription;
        [Export("adDescription")]
        string AdDescription { get; }

        // @property (readonly, nonatomic) NSMutableArray * surveyURLs;
        [Export("surveyURLs")]
        NSMutableArray SurveyURLs { get; }

        // @property (readonly, nonatomic) NSMutableArray * errorCodes;
        [Export("errorCodes")]
        NSMutableArray ErrorCodes { get; }

        // @property (readonly, nonatomic) NSMutableArray * errorURLs;
        [Export("errorURLs")]
        NSMutableArray ErrorURLs { get; }

        // @property (readonly, nonatomic) NSMutableArray * impressionURLs;
        [Export("impressionURLs")]
        NSMutableArray ImpressionURLs { get; }

        // @property (readonly, nonatomic) NSMutableArray * linearCreatives;
        [Export("linearCreatives")]
        NSMutableArray LinearCreatives { get; }

        // @property (readonly, nonatomic) NSMutableArray * nonLinearCreatives;
        [Export("nonLinearCreatives")]
        NSMutableArray NonLinearCreatives { get; }

        // @property (readonly, nonatomic) NSMutableArray * companionCreatives;
        [Export("companionCreatives")]
        NSMutableArray CompanionCreatives { get; }

        // @property (readonly, nonatomic) NSDictionary * extensions;
        [Export("extensions")]
        NSDictionary Extensions { get; }

        // // -(instancetype)initWithXML:(OOTBXMLElement *)xml;
        // [Export ("initWithXML:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* xml);

        // // -(BOOL)updateWithXML:(OOTBXMLElement *)xml;
        // [Export ("updateWithXML:")]
        // unsafe bool UpdateWithXML (OOTBXMLElement* xml);
    }

    // typedef OOStream * (^OOStreamSelector)(NSArray *);
    delegate OOStream OOStreamSelector(NSObject[] arg0);

    // @interface OOStream : NSObject
    [BaseType(typeof(NSObject))]
    interface OOStream
    {
        // @property (readonly, nonatomic) NSString * deliveryType;
        [Export("deliveryType")]
        string DeliveryType { get; }

        // @property (readonly, nonatomic) NSString * videoCodec;
        [Export("videoCodec")]
        string VideoCodec { get; }

        // @property (readonly, nonatomic) NSString * urlFormat;
        [Export("urlFormat")]
        string UrlFormat { get; }

        // @property (readonly, nonatomic) NSString * framerate;
        [Export("framerate")]
        string Framerate { get; }

        // @property (readonly, nonatomic) NSInteger videoBitrate;
        [Export("videoBitrate")]
        nint VideoBitrate { get; }

        // @property (readonly, nonatomic) NSInteger audioBitrate;
        [Export("audioBitrate")]
        nint AudioBitrate { get; }

        // @property (readonly, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; }

        // @property (readonly, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; }

        // @property (readonly, nonatomic) NSString * url;
        [Export("url")]
        string Url { get; }

        // @property (readonly, nonatomic) NSString * aspectRatio;
        [Export("aspectRatio")]
        string AspectRatio { get; }

        // @property (readonly, assign, nonatomic) BOOL isLiveStream;
        [Export("isLiveStream")]
        bool IsLiveStream { get; }

        // @property (readonly, nonatomic) NSString * profile;
        [Export("profile")]
        string Profile { get; }

        // @property (readonly, nonatomic) NSString * drmType;
        [Export("drmType")]
        string DrmType { get; }

        // @property (readonly, nonatomic) NSString * licenseUrl;
        [Export("licenseUrl")]
        string LicenseUrl { get; }

        // @property (readonly, nonatomic) NSString * certificateUrl;
        [Export("certificateUrl")]
        string CertificateUrl { get; }

        // -(NSInteger)combinedBitrate;
        [Export("combinedBitrate")]
        // [Verify (MethodToProperty)]
        nint CombinedBitrate { get; }

        // -(instancetype)initWithUrl:(NSURL *)theUrl deliveryType:(NSString *)theType;
        [Export("initWithUrl:deliveryType:")]
        IntPtr Constructor(NSUrl theUrl, string theType);

        // -(instancetype)initWithDictionary:(NSDictionary *)data;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary data);

        // // -(instancetype)initWithAssetDictionary:(NSDictionary *)data;
        // [Export ("initWithAssetDictionary:")]
        // IntPtr Constructor (NSDictionary data);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(NSURL *)decodedURL;
        [Export("decodedURL")]
        // [Verify (MethodToProperty)]
        NSUrl DecodedURL { get; }

        // +(BOOL)is:(OOStream *)stream betterThan:(OOStream *)better;
        [Static]
        [Export("is:betterThan:")]
        bool Is(OOStream stream, OOStream better);

        // +(BOOL)isPlayable:(OOStream *)stream;
        [Static]
        [Export("isPlayable:")]
        bool IsPlayable(OOStream stream);

        // +(BOOL)areSizeBitrateAndProfilePlayable:(OOStream *)stream;
        [Static]
        [Export("areSizeBitrateAndProfilePlayable:")]
        bool AreSizeBitrateAndProfilePlayable(OOStream stream);

        // +(BOOL)isDeliveryTypePlayable:(OOStream *)stream;
        [Static]
        [Export("isDeliveryTypePlayable:")]
        bool IsDeliveryTypePlayable(OOStream stream);

        // +(OOStream *)streamFromDictionary:(NSDictionary *)data;
        [Static]
        [Export("streamFromDictionary:")]
        OOStream StreamFromDictionary(NSDictionary data);

        // +(OOStream *)streamFromUrl:(NSURL *)url withType:(NSString *)type;
        [Static]
        [Export("streamFromUrl:withType:")]
        OOStream StreamFromUrl(NSUrl url, string type);

        // +(OOStream *)bestStreamFromArray:(NSArray *)streams;
        [Static]
        [Export("bestStreamFromArray:")]
        // [Verify (StronglyTypedNSArray)]
        OOStream BestStreamFromArray(NSObject[] streams);

        // +(BOOL)containsDeliveryType:(NSString *)type inArray:(NSArray *)streams;
        [Static]
        [Export("containsDeliveryType:inArray:")]
        // [Verify (StronglyTypedNSArray)]
        bool ContainsDeliveryType(string type, NSObject[] streams);

        // +(OOStream *)streamWithType:(NSString *)type fromArray:(NSArray *)streams;
        [Static]
        [Export("streamWithType:fromArray:")]
        // [Verify (StronglyTypedNSArray)]
        OOStream StreamWithType(string type, NSObject[] streams);

        // +(void)setStreamSelector:(OOStreamSelector)selector;
        [Static]
        [Export("setStreamSelector:")]
        void SetStreamSelector(OOStreamSelector selector);

        // +(void)resetStreamSelector;
        [Static]
        [Export("resetStreamSelector")]
        void ResetStreamSelector();
    }

    // @interface OOVASTStream : OOStream
    [BaseType(typeof(OOStream))]
    interface OOVASTStream
    {
        // @property (readonly, nonatomic) BOOL scalable;
        [Export("scalable")]
        bool Scalable { get; }

        // @property (readonly, nonatomic) BOOL maintainAspectRatio;
        [Export("maintainAspectRatio")]
        bool MaintainAspectRatio { get; }

        // @property (readonly, nonatomic, strong) NSString * vastDeliveryType;
        [Export("vastDeliveryType", ArgumentSemantic.Strong)]
        string VastDeliveryType { get; }

        // @property (readonly, nonatomic, strong) NSString * apiFramework;
        [Export("apiFramework", ArgumentSemantic.Strong)]
        string ApiFramework { get; }

        // // -(id)initWithXML:(OOTBXMLElement *)xml;
        // [Export ("initWithXML:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* xml);
    }

    // @interface OOVASTUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface OOVASTUtils
    {
        // +(NSString *)advertisingId;
        // +(void)setAdvertisingId:(NSString *)adId;
        [Static]
        [Export("advertisingId")]
        // [Verify (MethodToProperty)]
        string AdvertisingId { get; set; }

        // +(NSURL *)urlFromAdUrlString:(NSString *)url;
        [Static]
        [Export("urlFromAdUrlString:")]
        NSUrl UrlFromAdUrlString(string url);

        // +(void)logErrorCodes:(NSArray *)errorCodes;
        [Static]
        [Export("logErrorCodes:")]
        // [Verify (StronglyTypedNSArray)]
        void LogErrorCodes(NSObject[] errorCodes);

        // // +(BOOL)boolValueForAttribute:(NSString *)attribute element:(OOTBXMLElement *)element default:(BOOL)defaultValue;
        // [Static]
        // [Export ("boolValueForAttribute:element:default:")]
        // unsafe bool BoolValueForAttribute (string attribute, OOTBXMLElement* element, bool defaultValue);

        // // +(NSInteger)intValueForAttribute:(NSString *)attribute element:(OOTBXMLElement *)element default:(NSInteger)defaultValue;
        // [Static]
        // [Export ("intValueForAttribute:element:default:")]
        // unsafe nint IntValueForAttribute (string attribute, OOTBXMLElement* element, nint defaultValue);

        // // +(void)parseTrackingEventsWithElement:(OOTBXMLElement *)element dict:(NSMutableDictionary *)dict;
        // [Static]
        // [Export ("parseTrackingEventsWithElement:dict:")]
        // unsafe void ParseTrackingEventsWithElement (OOTBXMLElement* element, NSMutableDictionary dict);
    }

    // @interface OOFCCTVRatingStampView : UIView
    [BaseType(typeof(UIView))]
    interface OOFCCTVRatingStampView
    {
        // -(BOOL)pointInside:(CGPoint)point;
        [Export("pointInside:")]
        bool PointInside(CGPoint point);

        // @property (nonatomic) OOPlayer * player;
        [Export("player", ArgumentSemantic.Assign)]
        OOPlayer Player { get; set; }

        // @property (nonatomic) OOFCCTVRating * tvRating;
        [Export("tvRating", ArgumentSemantic.Assign)]
        OOFCCTVRating TvRating { get; set; }

        // @property (nonatomic) OOFCCTVRatingConfiguration * tvRatingConfiguration;
        [Export("tvRatingConfiguration", ArgumentSemantic.Assign)]
        OOFCCTVRatingConfiguration TvRatingConfiguration { get; set; }

        // @property (nonatomic) OOOoyalaPlayerVideoGravity videoGravity;
        [Export("videoGravity", ArgumentSemantic.Assign)]
        OOOoyalaPlayerVideoGravity VideoGravity { get; set; }
    }

    // @interface OOFCCTVRating : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface OOFCCTVRating
    {
        // @property (readonly, nonatomic) NSString * ageRestriction;
        [Export("ageRestriction")]
        string AgeRestriction { get; }

        // @property (readonly, nonatomic) NSString * labels;
        [Export("labels")]
        string Labels { get; }

        // @property (readonly, nonatomic) NSString * clickthroughUrl;
        [Export("clickthroughUrl")]
        string ClickthroughUrl { get; }

        // -(instancetype)initWithAgeRestriction:(NSString *)ageRestriction labels:(NSString *)labels clickthroughUrl:(NSString *)clickthroughUrl;
        [Export("initWithAgeRestriction:labels:clickthroughUrl:")]
        IntPtr Constructor(string ageRestriction, string labels, string clickthroughUrl);
    }

    // @interface OOFCCTVRatingVideoView : UIView
    [BaseType(typeof(UIView))]
    interface OOFCCTVRatingVideoView
    {
        // @property (nonatomic) OOFCCTVRating * tvRating;
        [Export("tvRating", ArgumentSemantic.Assign)]
        OOFCCTVRating TvRating { get; set; }

        // @property (nonatomic) OOFCCTVRatingConfiguration * tvRatingConfiguration;
        [Export("tvRatingConfiguration", ArgumentSemantic.Assign)]
        OOFCCTVRatingConfiguration TvRatingConfiguration { get; set; }

        // @property (nonatomic) OOOoyalaPlayerVideoGravity videoGravity;
        [Export("videoGravity", ArgumentSemantic.Assign)]
        OOOoyalaPlayerVideoGravity VideoGravity { get; set; }

        // -(void)setContentPlayerAndSubview:(OOPlayer *)player;
        [Export("setContentPlayerAndSubview:")]
        void SetContentPlayerAndSubview(OOPlayer player);

        // -(void)setAdPlayerAndSubview:(OOPlayer *)player;
        [Export("setAdPlayerAndSubview:")]
        void SetAdPlayerAndSubview(OOPlayer player);
    }

    // @interface OOUIUtils : NSObject
    [BaseType(typeof(NSObject))]
    interface OOUIUtils
    {
        // // +(void)doSafeGStateBlock:(void (^)(CGContextRef))block;
        // [Static]
        // [Export ("doSafeGStateBlock:")]
        // unsafe void DoSafeGStateBlock (Action<CoreGraphics.CGContextRef*> block);

        // +(UIColor *)colorByDarkening:(UIColor *)color by:(float)factor;
        [Static]
        [Export("colorByDarkening:by:")]
        UIColor ColorByDarkening(UIColor color, float factor);

        // +(UIImage *)imageFromBase64String:(NSString *)string;
        [Static]
        [Export("imageFromBase64String:")]
        UIImage ImageFromBase64String(string @string);

        // +(BOOL)isIpad;
        [Static]
        [Export("isIpad")]
        // [Verify (MethodToProperty)]
        bool IsIpad { get; }

        // +(BOOL)is1xDensity;
        [Static]
        [Export("is1xDensity")]
        // [Verify (MethodToProperty)]
        bool Is1xDensity { get; }

        // +(void)runOnMainThread:(void (^)(void))block;
        [Static]
        [Export("runOnMainThread:")]
        void RunOnMainThread(Action block);
    }

    // @interface OOClosedCaptionsView : UIView
    [BaseType(typeof(UIView))]
    interface OOClosedCaptionsView
    {
        // +(void)setArbitararyScalingFactor:(CGFloat)scalingFactor;
        [Static]
        [Export("setArbitararyScalingFactor:")]
        void SetArbitararyScalingFactor(nfloat scalingFactor);

        // @property (nonatomic, strong) OOCaption * caption;
        [Export("caption", ArgumentSemantic.Strong)]
        OOCaption Caption { get; set; }

        // @property (nonatomic, strong) OOClosedCaptionsStyle * style;
        [Export("style", ArgumentSemantic.Strong)]
        OOClosedCaptionsStyle Style { get; set; }
    }

    // typedef void (^OOEmbedTokenCallback)(NSString *);
    delegate void OOEmbedTokenCallback(string arg0);

    // @protocol OOEmbedTokenGenerator <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOEmbedTokenGenerator
    {
        // @required -(void)tokenForEmbedCodes:(NSArray *)embedCodes callback:(OOEmbedTokenCallback)callback;
        [Abstract]
        [Export("tokenForEmbedCodes:callback:")]
        // [Verify (StronglyTypedNSArray)]
        void Callback(NSObject[] embedCodes, OOEmbedTokenCallback callback);
    }

    // @interface OOOoyalaSimpleTVPlayerViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface OOOoyalaSimpleTVPlayerViewController
    {
        // @property (readonly, nonatomic) OOOoyalaTVPlayerControlType initialControlType;
        [Export("initialControlType")]
        OOOoyalaTVPlayerControlType InitialControlType { get; }

        // @property (nonatomic, strong) OOOoyalaPlayer * player;
        [Export("player", ArgumentSemantic.Strong)]
        OOOoyalaPlayer Player { get; set; }

        // @property (nonatomic, strong) UIView * inlineOverlay;
        [Export("inlineOverlay", ArgumentSemantic.Strong)]
        UIView InlineOverlay { get; set; }

        // @property (nonatomic, strong) UIView * fullscreenOverlay;
        [Export("fullscreenOverlay", ArgumentSemantic.Strong)]
        UIView FullscreenOverlay { get; set; }

        // @property (nonatomic, strong) OOClosedCaptionsStyle * closedCaptionsStyle;
        [Export("closedCaptionsStyle", ArgumentSemantic.Strong)]
        OOClosedCaptionsStyle ClosedCaptionsStyle { get; set; }

        // -(BOOL)isFullscreen;
        [Export("isFullscreen")]
        // [Verify (MethodToProperty)]
        bool IsFullscreen { get; }

        // -(void)setFullscreen:(BOOL)fullscreen;
        [Export("setFullscreen:")]
        void SetFullscreen(bool fullscreen);

        // -(id)initWithPlayer:(OOOoyalaPlayer *)player;
        [Export("initWithPlayer:")]
        IntPtr Constructor(OOOoyalaPlayer player);

        // -(id)initWithPlayer:(OOOoyalaPlayer *)player controlType:(OOOoyalaTVPlayerControlType)controlType;
        [Export("initWithPlayer:controlType:")]
        IntPtr Constructor(OOOoyalaPlayer player, OOOoyalaTVPlayerControlType controlType);

        // +(NSDictionary *)availableLocalizations;
        // +(void)setAvailableLocalizations:(NSDictionary *)localizations;
        [Static]
        [Export("availableLocalizations")]
        // [Verify (MethodToProperty)]
        NSDictionary AvailableLocalizations { get; set; }

        // +(void)loadDeviceLanguage;
        [Static]
        [Export("loadDeviceLanguage")]
        void LoadDeviceLanguage();

        // +(void)useLanguageStrings:(NSDictionary *)strings;
        [Static]
        [Export("useLanguageStrings:")]
        void UseLanguageStrings(NSDictionary strings);

        // +(NSDictionary *)getLanguageSettings:(NSString *)language;
        [Static]
        [Export("getLanguageSettings:")]
        NSDictionary GetLanguageSettings(string language);

        // +(NSDictionary *)currentLanguageSettings;
        [Static]
        [Export("currentLanguageSettings")]
        NSDictionary CurrentLanguageSettings();

        // -(OOControlsViewController *)getControls;
        [Export("getControls")]
        OOControlsViewController GetControls();

        // -(void)showControls;
        [Export("showControls")]
        void ShowControls();

        // -(void)hideControls;
        [Export("hideControls")]
        void HideControls();

        // -(void)setFullScreenButtonShowing:(BOOL)showing;
        [Export("setFullScreenButtonShowing:")]
        void SetFullScreenButtonShowing(bool showing);

        // -(void)setVolumeButtonShowing:(BOOL)showing;
        [Export("setVolumeButtonShowing:")]
        void SetVolumeButtonShowing(bool showing);

        // -(void)setFullScreenViewController:(OOControlsViewController *)controller;
        [Export("setFullScreenViewController:")]
        void SetFullScreenViewController(OOControlsViewController controller);

        // -(void)setInlineViewController:(OOControlsViewController *)controller;
        [Export("setInlineViewController:")]
        void SetInlineViewController(OOControlsViewController controller);

        // -(void)updateClosedCaptionsViewPosition:(CGRect)bottomControlsRect withControlsHide:(BOOL)hidden;
        [Export("updateClosedCaptionsViewPosition:withControlsHide:")]
        void UpdateClosedCaptionsViewPosition(CGRect bottomControlsRect, bool hidden);
    }

    // @protocol OOPlayerProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOPlayerProtocol
    {
        // @required -(BOOL)hasCustomControls;
        [Abstract]
        [Export("hasCustomControls")]
        // [Verify (MethodToProperty)]
        bool HasCustomControls { get; }

        // @required -(void)pause;
        [Abstract]
        [Export("pause")]
        void Pause();

        // @required -(void)play;
        [Abstract]
        [Export("play")]
        void Play();

        // @required -(void)stop;
        [Abstract]
        [Export("stop")]
        void Stop();

        // @required -(Float64)playheadTime;
        [Abstract]
        [Export("playheadTime")]
        // [Verify (MethodToProperty)]
        double PlayheadTime { get; }

        // @required -(Float64)duration;
        [Abstract]
        [Export("duration")]
        // [Verify (MethodToProperty)]
        double Duration { get; }

        // @required -(Float64)buffer;
        [Abstract]
        [Export("buffer")]
        // [Verify (MethodToProperty)]
        double Buffer { get; }

        // @required -(void)seekToTime:(Float64)time;
        [Abstract]
        [Export("seekToTime:")]
        void SeekToTime(double time);

        // @required -(UIImage *)screenshot;
        [Abstract]
        [Export("screenshot")]
        // [Verify (MethodToProperty)]
        UIImage Screenshot { get; }

        // @required -(void)setVideoGravity:(OOOoyalaPlayerVideoGravity)gravity;
        [Abstract]
        [Export("setVideoGravity:")]
        void SetVideoGravity(OOOoyalaPlayerVideoGravity gravity);

        // @required -(void)setClosedCaptionsLanguage:(NSString *)language;
        [Abstract]
        [Export("setClosedCaptionsLanguage:")]
        void SetClosedCaptionsLanguage(string language);

        // @required -(void)disablePlaylistClosedCaptions;
        [Abstract]
        [Export("disablePlaylistClosedCaptions")]
        void DisablePlaylistClosedCaptions();

        // @required @property (readonly, nonatomic) OOOoyalaPlayerState state;
        [Abstract]
        [Export("state")]
        OOOoyalaPlayerState State { get; }

        // @required @property (nonatomic) BOOL seekable;
        [Abstract]
        [Export("seekable")]
        bool Seekable { get; set; }

        // @required @property (readonly, nonatomic) CMTimeRange seekableTimeRange;
        [Abstract]
        [Export("seekableTimeRange")]
        CMTimeRange SeekableTimeRange { get; }

        // @required @property (nonatomic) BOOL allowsExternalPlayback;
        [Abstract]
        [Export("allowsExternalPlayback")]
        bool AllowsExternalPlayback { get; set; }

        // @required @property (nonatomic) BOOL usesExternalPlaybackWhileExternalScreenIsActive;
        [Abstract]
        [Export("usesExternalPlaybackWhileExternalScreenIsActive")]
        bool UsesExternalPlaybackWhileExternalScreenIsActive { get; set; }

        // @required @property (readonly, nonatomic) BOOL externalPlaybackActive;
        [Abstract]
        [Export("externalPlaybackActive")]
        bool ExternalPlaybackActive { get; }

        // @required @property (nonatomic) float rate;
        [Abstract]
        [Export("rate")]
        float Rate { get; set; }

        // @required @property (readonly, nonatomic) double bitrate;
        [Abstract]
        [Export("bitrate")]
        double Bitrate { get; }

        // @required @property (readonly, nonatomic) BOOL supportsVideoGravityButton;
        [Abstract]
        [Export("supportsVideoGravityButton")]
        bool SupportsVideoGravityButton { get; }

        // @required @property (readonly, getter = isLiveClosedCaptionsAvailable, nonatomic) BOOL liveClosedCaptionsAvailable;
        [Abstract]
        [Export("liveClosedCaptionsAvailable")]
        bool LiveClosedCaptionsAvailable { [Bind("isLiveClosedCaptionsAvailable")] get; }

        // @required @property (nonatomic) float volume;
        [Abstract]
        [Export("volume")]
        float Volume { get; set; }
    }

    // @interface OOOoyalaError : NSObject
    [BaseType(typeof(NSObject))]
    interface OOOoyalaError
    {
        // @property (readonly, nonatomic) OOOoyalaErrorCode code;
        [Export("code")]
        OOOoyalaErrorCode Code { get; }

        // @property (readonly, nonatomic) NSString * message;
        [Export("message")]
        string Message { get; }

        // @property (readonly, nonatomic) NSError * error;
        [Export("error")]
        NSError Error { get; }

        // @property (readonly, nonatomic) NSDictionary * userInfo;
        [Export("userInfo")]
        NSDictionary UserInfo { get; }

        // -(instancetype)initWithCode:(OOOoyalaErrorCode)code;
        [Export("initWithCode:")]
        IntPtr Constructor(OOOoyalaErrorCode code);

        // -(instancetype)initWithNSError:(NSError *)error;
        [Export("initWithNSError:")]
        IntPtr Constructor(NSError error);

        // -(instancetype)initWithNSError:(NSError *)error code:(OOOoyalaErrorCode)code;
        [Export("initWithNSError:code:")]
        IntPtr Constructor(NSError error, OOOoyalaErrorCode code);

        // -(instancetype)initWithCode:(OOOoyalaErrorCode)code description:(NSString *)description;
        [Export("initWithCode:description:")]
        IntPtr Constructor(OOOoyalaErrorCode code, string description);

        // -(instancetype)initWithCode:(OOOoyalaErrorCode)code description:(NSString *)description userInfo:(NSDictionary *)userInfo;
        [Export("initWithCode:description:userInfo:")]
        IntPtr Constructor(OOOoyalaErrorCode code, string description, NSDictionary userInfo);

        // +(OOOoyalaError *)errorWithCode:(OOOoyalaErrorCode)code description:(NSString *)description;
        [Static]
        [Export("errorWithCode:description:")]
        OOOoyalaError ErrorWithCode(OOOoyalaErrorCode code, string description);

        // +(OOOoyalaError *)errorWithNSError:(NSError *)error;
        [Static]
        [Export("errorWithNSError:")]
        OOOoyalaError ErrorWithNSError(NSError error);

        // +(OOOoyalaError *)errorWithNSError:(NSError *)error code:(OOOoyalaErrorCode)code;
        [Static]
        [Export("errorWithNSError:code:")]
        OOOoyalaError ErrorWithNSError(NSError error, OOOoyalaErrorCode code);

        // +(OOOoyalaError *)errorWithCode:(OOOoyalaErrorCode)code description:(NSString *)description userInfo:(NSDictionary *)userInfo;
        [Static]
        [Export("errorWithCode:description:userInfo:")]
        OOOoyalaError ErrorWithCode(OOOoyalaErrorCode code, string description, NSDictionary userInfo);
    }

    // @protocol OOLifeCycle
    [Protocol, Model]
    interface OOLifeCycle
    {
        // @required -(void)reset;
        [Abstract]
        [Export("reset")]
        void Reset();

        // @required -(void)suspend;
        [Abstract]
        [Export("suspend")]
        void Suspend();

        // @required -(void)resume;
        [Abstract]
        [Export("resume")]
        void Resume();

        // @required -(void)resume:(Float64)time stateToResume:(OOOoyalaPlayerState)state;
        [Abstract]
        [Export("resume:stateToResume:")]
        void Resume(double time, OOOoyalaPlayerState state);

        // @required -(void)destroy;
        [Abstract]
        [Export("destroy")]
        void Destroy();
    }

    // @protocol OOAudioTrackSelectionProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOAudioTrackSelectionProtocol
    {
        // @required -(NSArray *)availableAudioTracks;
        [Abstract]
        [Export("availableAudioTracks")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] AvailableAudioTracks { get; }

        // @required -(id<OOAudioTrackProtocol>)selectedAudioTrack;
        [Abstract]
        [Export("selectedAudioTrack")]
        // [Verify (MethodToProperty)]
        OOAudioTrackProtocol SelectedAudioTrack { get; }

        // @required -(void)setAudioTrack:(id<OOAudioTrackProtocol>)audioTrack;
        [Abstract]
        [Export("setAudioTrack:")]
        void SetAudioTrack(OOAudioTrackProtocol audioTrack);

        // @required -(id<OOAudioTrackProtocol>)defaultAudioTrack;
        [Abstract]
        [Export("defaultAudioTrack")]
        // [Verify (MethodToProperty)]
        OOAudioTrackProtocol DefaultAudioTrack { get; }
    }

    // @protocol OOPlaybackSpeedSelectionProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOPlaybackSpeedSelectionProtocol
    {
        // @required -(void)changePlaybackSpeedRate:(Float64)playbackSpeedRate;
        [Abstract]
        [Export("changePlaybackSpeedRate:")]
        void ChangePlaybackSpeedRate(double playbackSpeedRate);
    }

    // @interface OOPlayer : NSObject <OOPlayerProtocol, OOLifeCycle, OOAudioTrackSelectionProtocol, OOPlaybackSpeedSelectionProtocol>
    [BaseType(typeof(NSObject))]
    interface OOPlayer : OOPlayerProtocol, OOLifeCycle, OOAudioTrackSelectionProtocol, OOPlaybackSpeedSelectionProtocol
    {
        // @property (nonatomic) Float64 playheadTime;
        [Export("playheadTime")]
        double PlayheadTime { get; set; }

        // @property (readonly, nonatomic) OOOoyalaError * playerError;
        [Export("playerError")]
        OOOoyalaError PlayerError { get; }

        // @property (readonly, nonatomic) UIView * view;
        [Export("view")]
        UIView View { get; }

        // @property (nonatomic) BOOL completed;
        [Export("completed")]
        bool Completed { get; set; }

        // -(BOOL)isPlaying;
        [Export("isPlaying")]
        // [Verify (MethodToProperty)]
        bool IsPlaying { get; }

        // -(BOOL)isAudioOnlyStreamPlaying;
        [Export("isAudioOnlyStreamPlaying")]
        // [Verify (MethodToProperty)]
        bool IsAudioOnlyStreamPlaying { get; }

        // -(CMTimeRange)seekableTimeRange;
        [Export("seekableTimeRange")]
        // [Verify (MethodToProperty)]
        CMTimeRange SeekableTimeRange { get; }

        // -(CGRect)videoRect;
        [Export("videoRect")]
        // [Verify (MethodToProperty)]
        CGRect VideoRect { get; }

        // -(void)setState:(OOOoyalaPlayerState)state;
        [Export("setState:")]
        void SetState(OOOoyalaPlayerState state);
    }

    //[Static]
    //[Verify(ConstantsInterfaceAssociation)]
    //partial interface Constants
    //{
    //    // extern NSString *const PlayerErrorNotification;
    //    [Field("PlayerErrorNotification")]
    //    NSString PlayerErrorNotification { get; }
    //}

    // @interface OOStreamPlayer : OOPlayer
    [BaseType(typeof(OOPlayer))]
    interface OOStreamPlayer
    {
        // @property (readonly, nonatomic) OOSeekStyle seekStyle;
        [Export("seekStyle")]
        OOSeekStyle SeekStyle { get; }

        // @property (readonly, getter = isPiPActivated, nonatomic) BOOL pipActivated;
        [Export("pipActivated")]
        bool PipActivated { [Bind("isPiPActivated")] get; }

        // +(id<OOPlayerInfo>)defaultPlayerInfo;
        // +(void)setDefaultPlayerInfo:(id<OOPlayerInfo>)playerInfo;
        [Static]
        [Export("defaultPlayerInfo")]
        // [Verify (MethodToProperty)]
        OOPlayerInfo DefaultPlayerInfo { get; set; }

        // -(BOOL)setup:(NSArray *)streams parent:(OOOoyalaPlayer *)parent;
        [Export("setup:parent:")]
        // [Verify (StronglyTypedNSArray)]
        bool Setup(NSObject[] streams, OOOoyalaPlayer parent);

        // -(id<OOPlayerInfo>)playerInfo;
        [Export("playerInfo")]
        OOPlayerInfo PlayerInfo();

        // -(void)seekToTime:(Float64)time completion:(void (^)(void))onCompletion;
        [Export("seekToTime:completion:")]
        void SeekToTime(double time, Action onCompletion);

        // -(void)togglePictureInPictureMode;
        [Export("togglePictureInPictureMode")]
        void TogglePictureInPictureMode();

        // -(void)disablePlaylistClosedCaptions;
        [Export("disablePlaylistClosedCaptions")]
        void DisablePlaylistClosedCaptions();
    }

    // @interface OOAdSpotManager : NSObject
    [BaseType(typeof(NSObject))]
    interface OOAdSpotManager
    {
        // -(NSSet *)getCuePointsAtSeconds;
        [Export("getCuePointsAtSeconds")]
        // [Verify (MethodToProperty)]
        NSSet CuePointsAtSeconds { get; }

        // -(void)resetAds;
        [Export("resetAds")]
        void ResetAds();

        // -(void)clear;
        [Export("clear")]
        void Clear();

        // -(void)insertAd:(OOAdSpot *)ad;
        [Export("insertAd:")]
        void InsertAd(OOAdSpot ad);

        // -(void)insertAds:(NSArray *)adSpots;
        [Export("insertAds:")]
        // [Verify (StronglyTypedNSArray)]
        void InsertAds(NSObject[] adSpots);

        // -(OOAdSpot *)adBeforeTime:(Float64)time;
        [Export("adBeforeTime:")]
        OOAdSpot AdBeforeTime(double time);

        // -(void)markAsPlayed:(OOAdSpot *)ad;
        [Export("markAsPlayed:")]
        void MarkAsPlayed(OOAdSpot ad);

        // -(NSUInteger)count;
        [Export("count")]
        // [Verify (MethodToProperty)]
        nuint Count { get; }

        // -(OOAdSpot *)firstAd;
        [Export("firstAd")]
        // [Verify (MethodToProperty)]
        OOAdSpot FirstAd { get; }

        // -(OOAdSpot *)nextAd;
        [Export("nextAd")]
        // [Verify (MethodToProperty)]
        OOAdSpot NextAd { get; }

        // -(OOAdSpot *)lastAd;
        [Export("lastAd")]
        // [Verify (MethodToProperty)]
        OOAdSpot LastAd { get; }

        // -(BOOL)allAdsPlayed;
        [Export("allAdsPlayed")]
        // [Verify (MethodToProperty)]
        bool AllAdsPlayed { get; }

        // -(BOOL)adPlayed:(OOAdSpot *)ad;
        [Export("adPlayed:")]
        bool AdPlayed(OOAdSpot ad);
    }

    // @protocol OOAuthorizableItem <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOAuthorizableItem
    {
        // @required -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Abstract]
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // @required -(NSArray *)embedCodesToAuthorize;
        [Abstract]
        [Export("embedCodesToAuthorize")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] EmbedCodesToAuthorize { get; }

        // @required -(BOOL)authorized;
        [Abstract]
        [Export("authorized")]
        // [Verify (MethodToProperty)]
        bool Authorized { get; }

        // @required -(OOAuthCode)authCode;
        [Abstract]
        [Export("authCode")]
        // [Verify (MethodToProperty)]
        OOAuthCode AuthCode { get; }

        // @required @property (assign, nonatomic) BOOL heartbeatRequired;
        [Abstract]
        [Export("heartbeatRequired")]
        bool HeartbeatRequired { get; set; }
    }

    // @protocol OOPaginatedParentItem <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOPaginatedParentItem
    {
        // @required -(NSString *)embedCode;
        [Abstract]
        [Export("embedCode")]
        // [Verify (MethodToProperty)]
        string EmbedCode { get; }

        // @required -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Abstract]
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // @required -(BOOL)hasMoreChildren;
        [Abstract]
        [Export("hasMoreChildren")]
        // [Verify (MethodToProperty)]
        bool HasMoreChildren { get; }

        // @required -(NSString *)nextChildren;
        [Abstract]
        [Export("nextChildren")]
        // [Verify (MethodToProperty)]
        string NextChildren { get; }

        // @required -(BOOL)fetchMoreChildren:(OOFetchMoreChildrenCallback)callback;
        [Abstract]
        [Export("fetchMoreChildren:")]
        bool FetchMoreChildren(OOFetchMoreChildrenCallback callback);

        // @required -(NSUInteger)childrenCount;
        [Abstract]
        [Export("childrenCount")]
        // [Verify (MethodToProperty)]
        nuint ChildrenCount { get; }
    }

    // @interface OOOoyalaAPIClient : NSObject
    [BaseType(typeof(NSObject))]
    interface OOOoyalaAPIClient
    {
        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain;
        [Export("initWithPcode:domain:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain embedTokenGenerator:(id<OOEmbedTokenGenerator>)generator;
        [Export("initWithPcode:domain:embedTokenGenerator:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain, OOEmbedTokenGenerator generator);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain secureUrlGenerator:(id<OOSecureURLGenerator>)secureURLGenerator;
        [Export("initWithPcode:domain:secureUrlGenerator:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain, OOSecureURLGenerator secureURLGenerator);

        // -(instancetype)initWithAPIKey:(NSString *)apiKey secret:(NSString *)secret pcode:(NSString *)pcode domain:(OOPlayerDomain *)domain;
        [Export("initWithAPIKey:secret:pcode:domain:")]
        IntPtr Constructor(string apiKey, string secret, string pcode, OOPlayerDomain domain);

        // -(instancetype)initWithAPIKey:(NSString *)apiKey secret:(NSString *)secret pcode:(NSString *)pcode domain:(OOPlayerDomain *)domain embedTokenGenerator:(id<OOEmbedTokenGenerator>)generator;
        [Export("initWithAPIKey:secret:pcode:domain:embedTokenGenerator:")]
        IntPtr Constructor(string apiKey, string secret, string pcode, OOPlayerDomain domain, OOEmbedTokenGenerator generator);

        // -(instancetype)initWithPcode:(NSString *)pcode domain:(OOPlayerDomain *)domain embedTokenGenerator:(id<OOEmbedTokenGenerator>)generator secureUrlGenerator:(id<OOSecureURLGenerator>)secureURLGenerator;
        [Export("initWithPcode:domain:embedTokenGenerator:secureUrlGenerator:")]
        IntPtr Constructor(string pcode, OOPlayerDomain domain, OOEmbedTokenGenerator generator, OOSecureURLGenerator secureURLGenerator);

        // -(instancetype)initWithPlayerAPIClient:(OOPlayerAPIClient *)playerAPI secureUrlGenerator:(id<OOSecureURLGenerator>)secureURLGenerator;
        [Export("initWithPlayerAPIClient:secureUrlGenerator:")]
        IntPtr Constructor(OOOoyalaAPIClient playerAPI, OOSecureURLGenerator secureURLGenerator);

        // -(instancetype)initWithPlayerAPIClient:(OOPlayerAPIClient *)thePlayerAPIClient;
        [Export("initWithPlayerAPIClient:")]
        IntPtr Constructor(OOOoyalaAPIClient thePlayerAPIClient);

        // -(void)contentTree:(NSArray *)embedCodes callback:(OOContentTreeCallback)callback;
        [Export("contentTree:callback:")]
        // [Verify (StronglyTypedNSArray)]
        void ContentTree(NSObject[] embedCodes, OOContentTreeCallback callback);

        // -(void)contentTree:(NSArray *)embedCodes adSetCode:(NSString *)adSetCode callback:(OOContentTreeCallback)callback;
        [Export("contentTree:adSetCode:callback:")]
        // [Verify (StronglyTypedNSArray)]
        void ContentTree(NSObject[] embedCodes, string adSetCode, OOContentTreeCallback callback);

        // -(void)contentTreeByExternalIds:(NSArray *)externalIds callback:(OOContentTreeCallback)callback;
        [Export("contentTreeByExternalIds:callback:")]
        // [Verify (StronglyTypedNSArray)]
        void ContentTreeByExternalIds(NSObject[] externalIds, OOContentTreeCallback callback);

        // -(void)contentTreeNext:(id<OOPaginatedParentItem>)parent callback:(OOContentTreeNextCallback)callback;
        [Export("contentTreeNext:callback:")]
        void ContentTreeNext(OOPaginatedParentItem parent, OOContentTreeNextCallback callback);

        // -(void)objectFromBacklotAPI:(NSString *)uri params:(NSDictionary *)params withCallback:(OOObjectFromBacklotAPICallback)callback;
        [Export("objectFromBacklotAPI:params:withCallback:")]
        void ObjectFromBacklotAPI(string uri, NSDictionary @params, OOObjectFromBacklotAPICallback callback);

        // -(NSString *)pcode;
        [Export("pcode")]
        // [Verify (MethodToProperty)]
        string Pcode { get; }

        // -(OOPlayerDomain *)domain;
        [Export("domain")]
        // [Verify (MethodToProperty)]
        OOPlayerDomain Domain { get; }

        // +(NSString *)messageForAuthCode:(int)code;
        [Static]
        [Export("messageForAuthCode:")]
        string MessageForAuthCode(int code);
    }

    // @interface OOOoyalaAdSpot : OOManagedAdSpot <OOAuthorizableItem, OOPlayableItem>
    [BaseType(typeof(OOManagedAdSpot))]
    interface OOOoyalaAdSpot : OOAuthorizableItem, OOPlayableItem
    {
        // @property (readonly, nonatomic) NSMutableArray * streams;
        [Export("streams")]
        NSMutableArray Streams { get; }

        // @property (readonly, nonatomic) NSString * embedCode;
        [Export("embedCode")]
        string EmbedCode { get; }

        // @property (readonly, nonatomic) BOOL authorized;
        [Export("authorized")]
        bool Authorized { get; }

        // @property (readonly, nonatomic) OOAuthCode authCode;
        [Export("authCode")]
        OOAuthCode AuthCode { get; }

        // @property (assign, nonatomic) BOOL heartbeatRequired;
        [Export("heartbeatRequired")]
        bool HeartbeatRequired { get; set; }

        // -(instancetype)initWithTime:(NSNumber *)theTime clickURL:(NSURL *)theClickURL trackingURLs:(NSArray *)theTrackingURLs embedCode:(NSString *)theEmbedCode api:(OOOoyalaAPIClient *)theAPI;
        [Export("initWithTime:clickURL:trackingURLs:embedCode:api:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSNumber theTime, NSUrl theClickURL, NSObject[] theTrackingURLs, string theEmbedCode, OOOoyalaAPIClient theAPI);

        // -(instancetype)initWithDictionary:(NSDictionary *)data api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:api:")]
        IntPtr Constructor(NSDictionary data, OOOoyalaAPIClient theAPI);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(void)fetchPlaybackInfoWithCallback:(void (^)(BOOL))callback;
        [Export("fetchPlaybackInfoWithCallback:")]
        void FetchPlaybackInfoWithCallback(Action<bool> callback);

        // -(NSArray *)embedCodesToAuthorize;
        [Export("embedCodesToAuthorize")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] EmbedCodesToAuthorize { get; }
    }

    // @protocol OOAdSpotPluginDelegate
    [Protocol, Model]
    interface OOAdSpotPluginDelegate
    {
        // @required -(BOOL)playAd:(OOAdSpot *)ad;
        [Abstract]
        [Export("playAd:")]
        bool PlayAd(OOAdSpot ad);

        // @required -(void)onError;
        [Abstract]
        [Export("onError")]
        void OnError();

        // @required -(void)skipAd;
        [Abstract]
        [Export("skipAd")]
        void SkipAd();
    }

    // @interface OOAdSpotPlugin : NSObject <OOAdPlugin>
    [BaseType(typeof(NSObject))]
    interface OOAdSpotPlugin : OOAdPlugin
    {
        // @property (nonatomic) Float64 lastAdModeTime;
        [Export("lastAdModeTime")]
        double LastAdModeTime { get; set; }

        // @property (readonly) OOAdSpotManager * adSpotManager;
        [Export("adSpotManager")]
        OOAdSpotManager AdSpotManager { get; }

        // [Wrap ("WeakDelegate")]
        // OOAdSpotPluginDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<OOAdSpotPluginDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(BOOL)playAdsBeforeTime;
        [Export("playAdsBeforeTime")]
        // [Verify (MethodToProperty)]
        bool PlayAdsBeforeTime { get; }
    }

    // @interface OOAdPodInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface OOAdPodInfo
    {
        // @property (readonly, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) NSString * clickUrl;
        [Export("clickUrl")]
        string ClickUrl { get; }

        // @property (readonly, nonatomic) NSUInteger count;
        [Export("count")]
        nuint Count { get; }

        // @property (readonly, nonatomic) NSUInteger unplayedCount;
        [Export("unplayedCount")]
        nuint UnplayedCount { get; }

        // @property (readonly, nonatomic) Float64 skipoffset;
        [Export("skipoffset")]
        double Skipoffset { get; }

        // @property (readonly, nonatomic) NSMutableArray * icons;
        [Export("icons")]
        NSMutableArray Icons { get; }

        // @property (readonly, nonatomic) BOOL requireAdBar;
        [Export("requireAdBar")]
        bool RequireAdBar { get; }

        // @property (readonly, nonatomic) BOOL requireControls;
        [Export("requireControls")]
        bool RequireControls { get; }

        // -(instancetype)initWithTitle:(NSString *)title clickUrl:(NSString *)clickUrl count:(NSUInteger)adsCount unplayedCount:(NSUInteger)unplayedCount requiredAdBar:(BOOL)adbar requireControls:(BOOL)controls;
        [Export("initWithTitle:clickUrl:count:unplayedCount:requiredAdBar:requireControls:")]
        IntPtr Constructor(string title, string clickUrl, nuint adsCount, nuint unplayedCount, bool adbar, bool controls);

        // -(instancetype)initWithTitle:(NSString *)title clickUrl:(NSString *)clickUrl count:(NSUInteger)adsCount unplayedCount:(NSUInteger)unplayedCount skipoffset:(Float64)skipoffset icons:(NSMutableArray *)icons requiredAdBar:(BOOL)adbar requireControls:(BOOL)controls;
        [Export("initWithTitle:clickUrl:count:unplayedCount:skipoffset:icons:requiredAdBar:requireControls:")]
        IntPtr Constructor(string title, string clickUrl, nuint adsCount, nuint unplayedCount, double skipoffset, NSMutableArray icons, bool adbar, bool controls);

        // -(NSDictionary *)toDictionary;
        [Export("toDictionary")]
        // [Verify (MethodToProperty)]
        NSDictionary ToDictionary { get; }
    }

    // @interface OOAdOverlayInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface OOAdOverlayInfo
    {
        // @property (readonly, nonatomic) NSInteger width;
        [Export("width")]
        nint Width { get; }

        // @property (readonly, nonatomic) NSInteger height;
        [Export("height")]
        nint Height { get; }

        // @property (readonly, nonatomic) NSInteger expandedWidth;
        [Export("expandedWidth")]
        nint ExpandedWidth { get; }

        // @property (readonly, nonatomic) NSInteger expandedHeight;
        [Export("expandedHeight")]
        nint ExpandedHeight { get; }

        // @property (readonly, nonatomic) NSString * resourceUrl;
        [Export("resourceUrl")]
        string ResourceUrl { get; }

        // @property (readonly, nonatomic) NSString * clickUrl;
        [Export("clickUrl")]
        string ClickUrl { get; }

        // -(id)initWithWidth:(NSInteger)width height:(NSInteger)height expandedWidth:(NSInteger)expandedWidth expandedHeight:(NSInteger)expandedHeight resourceUrl:(NSString *)resourceUrl clickUrl:(NSString *)clickUrl;
        [Export("initWithWidth:height:expandedWidth:expandedHeight:resourceUrl:clickUrl:")]
        IntPtr Constructor(nint width, nint height, nint expandedWidth, nint expandedHeight, string resourceUrl, string clickUrl);

        // -(id)initWithNonLinear:(OOVASTNonLinear *)nonLinear;
        [Export("initWithNonLinear:")]
        IntPtr Constructor(OOVASTNonLinear nonLinear);
    }

    // @interface OOClientId : NSObject
    [BaseType(typeof(NSObject))]
    interface OOClientId
    {
        // +(NSString *)getId;
        [Static]
        [Export("getId")]
        // [Verify (MethodToProperty)]
        string Id { get; }

        // +(void)setId:(NSString *)clientId;
        [Static]
        [Export("setId:")]
        void SetId(string clientId);

        // +(void)resetId;
        [Static]
        [Export("resetId")]
        void ResetId();
    }

    // @interface OOSeekInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface OOSeekInfo
    {
        // @property (nonatomic) Float64 seekStart;
        [Export("seekStart")]
        double SeekStart { get; set; }

        // @property (nonatomic) Float64 seekEnd;
        [Export("seekEnd")]
        double SeekEnd { get; set; }

        // @property (nonatomic) Float64 totalDuration;
        [Export("totalDuration")]
        double TotalDuration { get; set; }

        // -(instancetype)initWithStartTime:(Float64)startTime endTime:(Float64)endTime andTotalDuration:(Float64)totalDuration;
        [Export("initWithStartTime:endTime:andTotalDuration:")]
        IntPtr Constructor(double startTime, double endTime, double totalDuration);
    }

    // @interface OOCaption : NSObject
    [BaseType(typeof(NSObject))]
    interface OOCaption
    {
        // @property (readonly, nonatomic) Float64 begin;
        [Export("begin")]
        double Begin { get; }

        // @property (readonly, nonatomic) Float64 end;
        [Export("end")]
        double End { get; }

        // @property (readonly, nonatomic, strong) NSString * text;
        [Export("text", ArgumentSemantic.Strong)]
        string Text { get; }

        // -(id)initWithBegin:(Float64)begin_ end:(Float64)end_ text:(NSString *)text_;
        [Export("initWithBegin:end:text:")]
        IntPtr Constructor(double begin_, double end_, string text_);

        // // -(id)initWithXML:(OOTBXMLElement *)xml;
        // [Export ("initWithXML:")]
        // unsafe IntPtr Constructor (OOTBXMLElement* xml);
    }

    // @interface OOClosedCaptions : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface OOClosedCaptions
    {
        // @property (readonly, nonatomic) NSArray * languages;
        [Export("languages")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] Languages { get; }

        // @property (readonly, nonatomic) NSString * defaultLanguage;
        [Export("defaultLanguage")]
        string DefaultLanguage { get; }

        // @property (readonly, nonatomic, strong) NSURL * url;
        [Export("url", ArgumentSemantic.Strong)]
        NSUrl Url { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * vttCaptions;
        [Export("vttCaptions", ArgumentSemantic.Strong)]
        NSDictionary VttCaptions { get; }

        // -(instancetype)initWithDictionary:(NSDictionary *)data;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary data);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(void)updateWithVttDictionary:(NSDictionary *)data;
        [Export("updateWithVttDictionary:")]
        void UpdateWithVttDictionary(NSDictionary data);

        // -(BOOL)fetchClosedCaptionsInfo;
        [Export("fetchClosedCaptionsInfo")]
        // [Verify (MethodToProperty)]
        bool FetchClosedCaptionsInfo { get; }

        // -(NSArray *)closedCaptionsForLanguage:(NSString *)language;
        [Export("closedCaptionsForLanguage:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] ClosedCaptionsForLanguage(string language);

        // -(OOCaption *)captionForLanguage:(NSString *)language time:(Float64)time;
        [Export("captionForLanguage:time:")]
        OOCaption CaptionForLanguage(string language, double time);
    }

    // @interface OOClosedCaptionsStyle : NSObject
    [BaseType(typeof(NSObject))]
    interface OOClosedCaptionsStyle
    {
        // @property (nonatomic, strong) UIColor * textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // @property (nonatomic) CGFloat textOpacity;
        [Export("textOpacity")]
        nfloat TextOpacity { get; set; }

        // @property (nonatomic) NSInteger textSize;
        [Export("textSize")]
        nint TextSize { get; set; }

        // @property (nonatomic, strong) NSString * textFontName;
        [Export("textFontName", ArgumentSemantic.Strong)]
        string TextFontName { get; set; }

        // @property (nonatomic, strong) UIColor * windowColor;
        [Export("windowColor", ArgumentSemantic.Strong)]
        UIColor WindowColor { get; set; }

        // @property (nonatomic) CGFloat windowOpacity;
        [Export("windowOpacity")]
        nfloat WindowOpacity { get; set; }

        // @property (nonatomic) OOClosedCaptionPresentation presentation;
        [Export("presentation", ArgumentSemantic.Assign)]
        OOClosedCaptionPresentation Presentation { get; set; }

        // @property (nonatomic) MACaptionAppearanceTextEdgeStyle edgeStyle;
        [Export("edgeStyle", ArgumentSemantic.Assign)]
        MACaptionAppearanceTextEdgeStyle EdgeStyle { get; set; }

        // @property (nonatomic) MACaptionAppearanceDisplayType displayType;
        [Export("displayType", ArgumentSemantic.Assign)]
        MACaptionAppearanceDisplayType DisplayType { get; set; }

        // @property (nonatomic, strong) UIColor * backgroundColor;
        [Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (nonatomic) CGFloat backgroundOpacity;
        [Export("backgroundOpacity")]
        nfloat BackgroundOpacity { get; set; }

        // -(void)updateStyle;
        [Export("updateStyle")]
        void UpdateStyle();

        // -(NSComparisonResult)compare:(OOClosedCaptionsStyle *)closedCaptionDeviceStyle;
        [Export("compare:")]
        NSComparisonResult Compare(OOClosedCaptionsStyle closedCaptionDeviceStyle);
    }

    // @interface OOClosedCaptionsLabel : UILabel
    [BaseType(typeof(UILabel))]
    interface OOClosedCaptionsLabel
    {
        // -(id)initWithFrame:(CGRect)frame isUniformEdge:(BOOL)isUniformEdge;
        [Export("initWithFrame:isUniformEdge:")]
        IntPtr Constructor(CGRect frame, bool isUniformEdge);
    }

    // @interface OOContentItem : NSObject <OOAuthorizableItem>
    [BaseType(typeof(NSObject))]
    interface OOContentItem : OOAuthorizableItem
    {
        // @property (readonly, nonatomic) NSString * embedCode;
        [Export("embedCode")]
        string EmbedCode { get; }

        // @property (readonly, nonatomic) NSString * externalId;
        [Export("externalId")]
        string ExternalId { get; }

        // @property (readonly, nonatomic) NSString * title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, nonatomic) NSString * itemDescription;
        [Export("itemDescription")]
        string ItemDescription { get; }

        // @property (readonly, nonatomic) NSString * promoImageURL;
        [Export("promoImageURL")]
        string PromoImageURL { get; }

        // @property (readonly, nonatomic) NSString * hostedAtURL;
        [Export("hostedAtURL")]
        string HostedAtURL { get; }

        // @property (readonly, nonatomic) OOPlayerAPIClient * api;
        [Export("api")]
        OOOoyalaAPIClient Api { get; }

        // @property (readonly, nonatomic) BOOL authorized;
        [Export("authorized")]
        bool Authorized { get; }

        // @property (readonly, nonatomic) OOAuthCode authCode;
        [Export("authCode")]
        OOAuthCode AuthCode { get; }

        // @property (readonly, nonatomic) NSDictionary * metadata;
        [Export("metadata")]
        NSDictionary Metadata { get; }

        // @property (readonly, nonatomic) NSDictionary * moduleData;
        [Export("moduleData")]
        NSDictionary ModuleData { get; }

        // @property (assign, nonatomic) BOOL heartbeatRequired;
        [Export("heartbeatRequired")]
        bool HeartbeatRequired { get; set; }

        // @property (readonly, nonatomic) OOFCCTVRating * tvRating;
        [Export("tvRating")]
        OOFCCTVRating TvRating { get; }

        // @property (readonly, nonatomic) NSString * assetPcode;
        [Export("assetPcode")]
        string AssetPcode { get; }

        // @property (readonly, nonatomic) NSDictionary * movieAttributes;
        [Export("movieAttributes")]
        NSDictionary MovieAttributes { get; }

        // @property (readonly, nonatomic) BOOL haEnabled;
        [Export("haEnabled")]
        bool HaEnabled { get; }

        // @property (readonly, nonatomic) BOOL needsMidStreamCheck;
        [Export("needsMidStreamCheck")]
        bool NeedsMidStreamCheck { get; }

        // @property (readonly, nonatomic) int midStreamCheckInterval;
        [Export("midStreamCheckInterval")]
        int MidStreamCheckInterval { get; }

        // @property (readonly, nonatomic) SsaiMetadata * ssaiMetadata;
        [Export("ssaiMetadata")]
        //Hack
        NSObject SsaiMetadata { get; }

        // @property (readonly, nonatomic) NSString * contentType;
        [Export("contentType")]
        string ContentType { get; }

        // @property (readonly, nonatomic) NSMutableArray * externalAds;
        [Export("externalAds")]
        NSMutableArray ExternalAds { get; }

        // -(instancetype)initWithEmbedCode:(NSString *)theEmbedCode title:(NSString *)theTitle description:(NSString *)theDescription;
        [Export("initWithEmbedCode:title:description:")]
        IntPtr Constructor(string theEmbedCode, string theTitle, string theDescription);

        // -(instancetype)initWithDictionary:(NSDictionary *)data embedCode:(NSString *)theEmbedCode api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCode:api:")]
        IntPtr Constructor(NSDictionary data, string theEmbedCode, OOOoyalaAPIClient theAPI);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(NSString *)getPromoImageURLForWidth:(NSInteger)width height:(NSInteger)height;
        [Export("getPromoImageURLForWidth:height:")]
        string GetPromoImageURLForWidth(nint width, nint height);

        // -(NSArray *)embedCodesToAuthorize;
        [Export("embedCodesToAuthorize")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] EmbedCodesToAuthorize { get; }

        // -(OOVideo *)firstVideo;
        [Export("firstVideo")]
        // [Verify (MethodToProperty)]
        OOVideo FirstVideo { get; }

        // -(OOVideo *)videoFromEmbedCode:(NSString *)embedCode withCurrentItem:(OOVideo *)currentItem;
        [Export("videoFromEmbedCode:withCurrentItem:")]
        OOVideo VideoFromEmbedCode(string embedCode, OOVideo currentItem);

        // +(OOContentItem *)contentItemFromDictionary:(NSDictionary *)data embedCode:(NSString *)embedCode api:(OOPlayerAPIClient *)api;
        [Static]
        [Export("contentItemFromDictionary:embedCode:api:")]
        OOContentItem ContentItemFromDictionary(NSDictionary data, string embedCode, OOOoyalaAPIClient api);

        // +(OOContentItem *)contentItemFromDictionary:(NSDictionary *)data embedCodes:(NSArray *)embedCodes api:(OOPlayerAPIClient *)api;
        [Static]
        [Export("contentItemFromDictionary:embedCodes:api:")]
        // [Verify (StronglyTypedNSArray)]
        OOContentItem ContentItemFromDictionary(NSDictionary data, NSObject[] embedCodes, OOOoyalaAPIClient api);

        // -(Float64)duration;
        [Export("duration")]
        // [Verify (MethodToProperty)]
        double Duration { get; }
    }

    // @interface OOChannel : OOContentItem <OOPaginatedParentItem>
    [BaseType(typeof(OOContentItem))]
    interface OOChannel : OOPaginatedParentItem
    {
        // // @property (readonly, nonatomic, strong) NSString * nextChildren;
        // [Export ("nextChildren", ArgumentSemantic.Strong)]
        // string NextChildren { get; }

        // @property (readonly, nonatomic, strong) OOOrderedDictionary * videos;
        [Export("videos", ArgumentSemantic.Strong)]
        OOOrderedDictionary Videos { get; }

        // @property (readonly, nonatomic, strong) OOChannelSet * parent;
        [Export("parent", ArgumentSemantic.Strong)]
        OOChannelSet Parent { get; }

        // -(instancetype)initWithDictionary:(NSDictionary *)data embedCode:(NSString *)theEmbedCode api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCode:api:")]
        IntPtr Constructor(NSDictionary data, string theEmbedCode, OOOoyalaAPIClient theAPI);

        // -(instancetype)initWithDictionary:(NSDictionary *)data embedCode:(NSString *)theEmbedCode parent:(OOChannelSet *)theParent api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCode:parent:api:")]
        IntPtr Constructor(NSDictionary data, string theEmbedCode, OOChannelSet theParent, OOOoyalaAPIClient theAPI);

        // // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        // [Export ("updateWithDictionary:")]
        // OOReturnState UpdateWithDictionary (NSDictionary data);

        // -(OOVideo *)firstVideo;
        [Export("firstVideo")]
        //[Verify(MethodToProperty)]
        OOVideo FirstVideo { get; }

        // -(OOVideo *)lastVideo;
        [Export("lastVideo")]
        //[Verify(MethodToProperty)]
        OOVideo LastVideo { get; }

        // -(OOVideo *)nextVideo:(OOVideo *)currentItem;
        [Export("nextVideo:")]
        OOVideo NextVideo(OOVideo currentItem);

        // -(OOVideo *)previousVideo:(OOVideo *)currentItem;
        [Export("previousVideo:")]
        OOVideo PreviousVideo(OOVideo currentItem);

        // -(OOVideo *)videoFromEmbedCode:(NSString *)embedCode withCurrentItem:(OOVideo *)currentItem;
        [Export("videoFromEmbedCode:withCurrentItem:")]
        OOVideo VideoFromEmbedCode(string embedCode, OOVideo currentItem);

        // // -(BOOL)hasMoreChildren;
        // [Export ("hasMoreChildren")]
        // [Verify (MethodToProperty)]
        // bool HasMoreChildren { get; }

        // // -(BOOL)fetchMoreChildren:(OOFetchMoreChildrenCallback)callback;
        // [Export ("fetchMoreChildren:")]
        // bool FetchMoreChildren (OOFetchMoreChildrenCallback callback);

        // -(void)fetchAndAuthorizeMoreChildren:(OOFetchMoreChildrenCallback)callback;
        [Export("fetchAndAuthorizeMoreChildren:")]
        void FetchAndAuthorizeMoreChildren(OOFetchMoreChildrenCallback callback);

        // // -(NSUInteger)childrenCount;
        // [Export ("childrenCount")]
        // [Verify (MethodToProperty)]
        // nuint ChildrenCount { get; }

        // -(Float64)duration;
        [Export("duration")]
        // [Verify (MethodToProperty)]
        double Duration { get; }
    }

    // @interface OOChannelSet : OOContentItem <OOPaginatedParentItem>
    [BaseType(typeof(OOContentItem))]
    interface OOChannelSet : OOPaginatedParentItem
    {
        // // @property (readonly, nonatomic) NSString * nextChildren;
        // [Export ("nextChildren")]
        // string NextChildren { get; }

        // @property (readonly, nonatomic) OOOrderedDictionary * channels;
        [Export("channels")]
        OOOrderedDictionary Channels { get; }

        // -(instancetype)initWithDictionary:(NSDictionary *)data embedCode:(NSString *)theEmbedCode api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCode:api:")]
        IntPtr Constructor(NSDictionary data, string theEmbedCode, OOOoyalaAPIClient theAPI);

        // // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        // [Export ("updateWithDictionary:")]
        // OOReturnState UpdateWithDictionary (NSDictionary data);

        // -(OOVideo *)firstVideo;
        [Export("firstVideo")]
        // [Verify (MethodToProperty)]
        OOVideo FirstVideo { get; }

        // -(OOVideo *)nextVideo:(OOChannel *)currentItem;
        [Export("nextVideo:")]
        OOVideo NextVideo(OOChannel currentItem);

        // -(OOVideo *)previousVideo:(OOChannel *)currentItem;
        [Export("previousVideo:")]
        OOVideo PreviousVideo(OOChannel currentItem);

        // -(OOVideo *)videoFromEmbedCode:(NSString *)embedCode withCurrentItem:(OOVideo *)currentItem;
        [Export("videoFromEmbedCode:withCurrentItem:")]
        OOVideo VideoFromEmbedCode(string embedCode, OOVideo currentItem);

        // // -(BOOL)hasMoreChildren;
        // [Export ("hasMoreChildren")]
        // [Verify (MethodToProperty)]
        // bool HasMoreChildren { get; }

        // // -(BOOL)fetchMoreChildren:(OOFetchMoreChildrenCallback)callback;
        // [Export ("fetchMoreChildren:")]
        // bool FetchMoreChildren (OOFetchMoreChildrenCallback callback);

        // -(void)fetchAndAuthorizeMoreChildren:(OOFetchMoreChildrenCallback)callback;
        [Export("fetchAndAuthorizeMoreChildren:")]
        void FetchAndAuthorizeMoreChildren(OOFetchMoreChildrenCallback callback);

        // // -(NSUInteger)childrenCount;
        // [Export ("childrenCount")]
        // [Verify (MethodToProperty)]
        // nuint ChildrenCount { get; }

        // -(Float64)duration;
        [Export("duration")]
        // [Verify (MethodToProperty)]
        double Duration { get; }
    }

    // @interface OODynamicChannel : OOChannel
    [BaseType(typeof(OOChannel))]
    interface OODynamicChannel
    {
        // @property (readonly, nonatomic, strong) NSArray * embedCodes;
        [Export("embedCodes", ArgumentSemantic.Strong)]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] EmbedCodes { get; }

        // -(id)initWithDictionary:(NSDictionary *)data embedCodes:(NSArray *)theEmbedCodes api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCodes:api:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSDictionary data, NSObject[] theEmbedCodes, OOOoyalaAPIClient theAPI);

        // -(id)initWithDictionary:(NSDictionary *)data embedCodes:(NSArray *)theEmbedCodes parent:(OOChannelSet *)theParent api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCodes:parent:api:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSDictionary data, NSObject[] theEmbedCodes, OOChannelSet theParent, OOOoyalaAPIClient theAPI);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(NSArray *)embedCodesToAuthorize;
        [Export("embedCodesToAuthorize")]
        // [Verify (MethodToProperty), Verify (StronglyTypedNSArray)]
        NSObject[] EmbedCodesToAuthorize { get; }

        // -(Float64)duration;
        [Export("duration")]
        // [Verify (MethodToProperty)]
        double Duration { get; }
    }

    // @interface OOVideo : OOContentItem <OOPlayableItem>
    [BaseType(typeof(OOContentItem))]
    interface OOVideo : OOPlayableItem
    {
        // @property (readonly, nonatomic) NSMutableArray * ads;
        [Export("ads")]
        NSMutableArray Ads { get; }

        // @property (readonly, nonatomic) OOClosedCaptions * closedCaptions;
        [Export("closedCaptions")]
        OOClosedCaptions ClosedCaptions { get; }

        // @property (readonly, nonatomic) OOChannel * parent;
        [Export("parent")]
        OOChannel Parent { get; }

        // @property (readonly, nonatomic) Float64 duration;
        [Export("duration")]
        double Duration { get; }

        // @property (readonly, nonatomic) BOOL live;
        [Export("live")]
        bool Live { get; }

        // @property (readonly, nonatomic) NSURL * fairplayKeyURL;
        [Export("fairplayKeyURL")]
        NSUrl FairplayKeyURL { get; }

        // @property (nonatomic) int retryCount;
        [Export("retryCount")]
        int RetryCount { get; set; }

        // @property (readonly, nonatomic) NSString * defaultLanguageCode;
        [Export("defaultLanguageCode")]
        string DefaultLanguageCode { get; }

        // -(instancetype)initWithUnbundledVideo:(OOUnbundledVideo *)unbundledVideo;
        [Export("initWithUnbundledVideo:")]
        IntPtr Constructor(OOUnbundledVideo unbundledVideo);

        // -(instancetype)initWithUnbundledStreams:(NSArray *)theStreams ads:(NSArray *)theAds;
        [Export("initWithUnbundledStreams:ads:")]
        // [Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] theStreams, NSObject[] theAds);

        // -(instancetype)initWithDictionary:(NSDictionary *)data embedCode:(NSString *)theEmbedCode api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCode:api:")]
        IntPtr Constructor(NSDictionary data, string theEmbedCode, OOOoyalaAPIClient theAPI);

        // -(instancetype)initWithDictionary:(NSDictionary *)data embedCode:(NSString *)theEmbedCode parent:(OOChannel *)theParent api:(OOPlayerAPIClient *)theAPI;
        [Export("initWithDictionary:embedCode:parent:api:")]
        IntPtr Constructor(NSDictionary data, string theEmbedCode, OOChannel theParent, OOOoyalaAPIClient theAPI);

        // -(OOReturnState)updateWithDictionary:(NSDictionary *)data;
        [Export("updateWithDictionary:")]
        OOReturnState UpdateWithDictionary(NSDictionary data);

        // -(BOOL)updateHighAvailabilityWithDictionary:(NSDictionary *)data;
        [Export("updateHighAvailabilityWithDictionary:")]
        bool UpdateHighAvailabilityWithDictionary(NSDictionary data);

        // -(OOVideo *)firstVideo;
        [Export("firstVideo")]
        // [Verify (MethodToProperty)]
        OOVideo FirstVideo { get; }

        // -(OOVideo *)nextVideo;
        [Export("nextVideo")]
        // [Verify (MethodToProperty)]
        OOVideo NextVideo { get; }

        // -(OOVideo *)previousVideo;
        [Export("previousVideo")]
        // [Verify (MethodToProperty)]
        OOVideo PreviousVideo { get; }

        // -(OOVideo *)videoFromEmbedCode:(NSString *)embedCode withCurrentItem:(OOVideo *)currentItem;
        [Export("videoFromEmbedCode:withCurrentItem:")]
        OOVideo VideoFromEmbedCode(string embedCode, OOVideo currentItem);

        // -(BOOL)fetchPlaybackInfo;
        [Export("fetchPlaybackInfo")]
        // [Verify (MethodToProperty)]
        bool FetchPlaybackInfo { get; }

        // -(id)fetchPlaybackInfo:(void (^)(BOOL))callback;
        [Export("fetchPlaybackInfo:")]
        NSObject FetchPlaybackInfoWithCallback(Action<bool> callback);

        // -(BOOL)hasAds;
        [Export("hasAds")]
        // [Verify (MethodToProperty)]
        bool HasAds { get; }

        // -(BOOL)hasClosedCaptions;
        [Export("hasClosedCaptions")]
        // [Verify (MethodToProperty)]
        bool HasClosedCaptions { get; }

        // -(void)insertAd:(OOManagedAdSpot *)ad;
        [Export("insertAd:")]
        void InsertAd(OOManagedAdSpot ad);

        // -(void)filterAds:(NSPredicate *)predicate;
        [Export("filterAds:")]
        void FilterAds(NSPredicate predicate);

        // -(BOOL)isSsaiEnabled;
        [Export("isSsaiEnabled")]
        // [Verify (MethodToProperty)]
        bool IsSsaiEnabled { get; }
    }

    // @interface OOClosedCaptionsItem : NSObject
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface OOClosedCaptionsItem
    {
        // @property (nonatomic) NSString * name;
        [Export("name")]
        string Name { get; set; }

        // @property (nonatomic) NSString * url;
        [Export("url")]
        string Url { get; set; }

        // -(instancetype)initWithDictionary:(NSDictionary *)dictionary;
        [Export("initWithDictionary:")]
        IntPtr Constructor(NSDictionary dictionary);
    }

    // @interface OOUnbundledVideo : NSObject
    [BaseType(typeof(NSObject))]
    interface OOUnbundledVideo
    {
        // @property (readonly, nonatomic) NSArray * streams;
        [Export("streams")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] Streams { get; }

        // @property (readonly, nonatomic) NSArray * ads;
        [Export("ads")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] Ads { get; }

        // -(id)initWithUnbundledStreams:(NSArray *)streams;
        [Export("initWithUnbundledStreams:")]
        // [Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] streams);

        // -(id)initWithUnbundledStreams:(NSArray *)streams ads:(NSArray *)ads;
        [Export("initWithUnbundledStreams:ads:")]
        // [Verify (StronglyTypedNSArray), Verify (StronglyTypedNSArray)]
        IntPtr Constructor(NSObject[] streams, NSObject[] ads);
    }

    // @interface OOOfflineVideo : OOUnbundledVideo
    [BaseType(typeof(OOUnbundledVideo))]
    [DisableDefaultCtor]
    interface OOOfflineVideo
    {
        // @property (readonly, nonatomic) NSURL * keyLocation;
        [Export("keyLocation")]
        NSUrl KeyLocation { get; }

        // -(instancetype)initWithVideoLocation:(NSURL *)location __attribute__((objc_designated_initializer));
        [Export("initWithVideoLocation:")]
        [DesignatedInitializer]
        IntPtr Constructor(NSUrl location);

        // -(instancetype)initWithVideoLocation:(NSURL *)location fairplayKeyLocation:(NSURL *)keyLocation;
        [Export("initWithVideoLocation:fairplayKeyLocation:")]
        IntPtr Constructor(NSUrl location, NSUrl keyLocation);

        // +(OOOfflineVideo *)videoWithVideoLocation:(NSURL *)location;
        [Static]
        [Export("videoWithVideoLocation:")]
        OOOfflineVideo VideoWithVideoLocation(NSUrl location);

        // +(OOOfflineVideo *)videoWithVideoLocation:(NSURL *)location fairplayKeyLocation:(NSURL *)keyLocation;
        [Static]
        [Export("videoWithVideoLocation:fairplayKeyLocation:")]
        OOOfflineVideo VideoWithVideoLocation(NSUrl location, NSUrl keyLocation);
    }

    // @protocol OOAudioTrackProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOAudioTrackProtocol
    {
        // @required @property (readonly, nonatomic) NSString * name;
        [Abstract]
        [Export("name")]
        string Name { get; }

        // @required @property (readonly, nonatomic) NSString * title;
        [Abstract]
        [Export("title")]
        string Title { get; }

        // @required @property (readonly, nonatomic) NSString * languageCode;
        [Abstract]
        [Export("languageCode")]
        string LanguageCode { get; }

        // @required @property (readonly, nonatomic) AVMediaSelectionOption * mediaSelectionOption;
        [Abstract]
        [Export("mediaSelectionOption")]
        AVMediaSelectionOption MediaSelectionOption { get; }
    }

    // @interface OODiscoveryOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface OODiscoveryOptions
    {
        // @property OODiscoveryType type;
        [Export("type", ArgumentSemantic.Assign)]
        OODiscoveryType Type { get; set; }

        // @property int limit;
        [Export("limit")]
        int Limit { get; set; }

        // @property NSTimeInterval timeout;
        [Export("timeout")]
        double Timeout { get; set; }

        // -(instancetype)initWithType:(OODiscoveryType)type limit:(int)limit timeout:(NSTimeInterval)timeout;
        [Export("initWithType:limit:timeout:")]
        IntPtr Constructor(OODiscoveryType type, int limit, double timeout);
    }

    // typedef void (^OODiscoveryResultsCallback)(NSArray *, OOOoyalaError *);
    delegate void OODiscoveryResultsCallback(NSObject[] arg0, OOOoyalaError arg1);

    // @interface OODiscoveryManager : NSObject
    [BaseType(typeof(NSObject))]
    interface OODiscoveryManager
    {
        // +(void)getResults:(OODiscoveryOptions *)options embedCode:(NSString *)embedCode pcode:(NSString *)pcode parameters:(NSDictionary *)parameters callback:(OODiscoveryResultsCallback)callback;
        [Static]
        [Export("getResults:embedCode:pcode:parameters:callback:")]
        void GetResults(OODiscoveryOptions options, string embedCode, string pcode, NSDictionary parameters, OODiscoveryResultsCallback callback);

        // +(void)sendImpression:(OODiscoveryOptions *)options bucketInfo:(NSString *)bucketInfo pcode:(NSString *)pcode parameters:(NSDictionary *)parameters;
        [Static]
        [Export("sendImpression:bucketInfo:pcode:parameters:")]
        void SendImpression(OODiscoveryOptions options, string bucketInfo, string pcode, NSDictionary parameters);

        // +(void)sendClick:(OODiscoveryOptions *)options bucketInfo:(NSString *)bucketInfo pcode:(NSString *)pcode parameters:(NSDictionary *)parameters;
        [Static]
        [Export("sendClick:bucketInfo:pcode:parameters:")]
        void SendClick(OODiscoveryOptions options, string bucketInfo, string pcode, NSDictionary parameters);
    }

    // @interface OODebugMode : NSObject
    [BaseType(typeof(NSObject))]
    interface OODebugMode
    {
        // +(DebugMode)getDebugMode;
        [Static]
        [Export("getDebugMode")]
        // [Verify (MethodToProperty)]
        DebugMode DebugMode { get; }

        // +(void)setDebugMode:(DebugMode)mode;
        [Static]
        [Export("setDebugMode:")]
        void SetDebugMode(DebugMode mode);

        // +(void)assert:(BOOL)condition tag:(NSString *)tag message:(NSString *)format, ...;
        [Static, Internal]
        [Export("assert:tag:message:", IsVariadic = true)]
        void Assert(bool condition, string tag, string format, IntPtr varArgs);

        // +(void)assertFalse:(NSString *)tag message:(NSString *)format, ...;
        [Static, Internal]
        [Export("assertFalse:message:", IsVariadic = true)]
        void AssertFalse(string tag, string format, IntPtr varArgs);

        // +(void)log:(NSString *)tag message:(NSString *)format, ...;
        [Static, Internal]
        [Export("log:message:", IsVariadic = true)]
        void Log(string tag, string format, IntPtr varArgs);
    }

    // @interface OOOrderedDictionary : NSObject <NSFastEnumeration>
    [BaseType(typeof(NSObject))]
    interface OOOrderedDictionary //: INSFastEnumeration
    {
        // @property (assign, nonatomic) SEL keySelector;
        [Export("keySelector", ArgumentSemantic.Assign)]
        Selector KeySelector { get; set; }

        // -(id)initWithKeySelector:(SEL)keySelector;
        [Export("initWithKeySelector:")]
        IntPtr Constructor(Selector keySelector);

        // -(id)initWithCapacity:(NSUInteger)numItems;
        [Export("initWithCapacity:")]
        IntPtr Constructor(nuint numItems);

        // -(id)initWithCapacity:(NSUInteger)numItems keySelector:(SEL)keySelector;
        [Export("initWithCapacity:keySelector:")]
        IntPtr Constructor(nuint numItems, Selector keySelector);

        // -(void)setObject:(id)obj forKey:(id)key;
        [Export("setObject:forKey:")]
        void SetObject(NSObject obj, NSObject key);

        // -(void)addObject:(id)obj;
        [Export("addObject:")]
        void AddObject(NSObject obj);

        // -(id)objectForKey:(id)key;
        [Export("objectForKey:")]
        NSObject ObjectForKey(NSObject key);

        // -(NSInteger)indexForKey:(id)key;
        [Export("indexForKey:")]
        nint IndexForKey(NSObject key);

        // -(NSInteger)indexForValue:(id)value;
        [Export("indexForValue:")]
        nint IndexForValue(NSObject value);

        // -(id)objectAtIndex:(NSInteger)index;
        [Export("objectAtIndex:")]
        NSObject ObjectAtIndex(nint index);

        // -(void)removeObject:(id)obj;
        [Export("removeObject:")]
        void RemoveObject(NSObject obj);

        // -(void)removeObjectAtIndex:(NSInteger)index;
        [Export("removeObjectAtIndex:")]
        void RemoveObjectAtIndex(nint index);

        // -(void)removeObjectIdenticalTo:(id)obj;
        [Export("removeObjectIdenticalTo:")]
        void RemoveObjectIdenticalTo(NSObject obj);

        // -(void)sortUsingSelector:(SEL)comparator;
        [Export("sortUsingSelector:")]
        void SortUsingSelector(Selector comparator);

        // -(void)sortWithOptions:(NSSortOptions)opts usingComparator:(NSComparator)cmptr;
        [Export("sortWithOptions:usingComparator:")]
        void SortWithOptions(NSSortOptions opts, NSComparator cmptr);

        // -(NSUInteger)count;
        [Export("count")]
        // [Verify (MethodToProperty)]
        nuint Count { get; }

        // -(NSArray *)objectsInRange:(NSRange)range;
        [Export("objectsInRange:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] ObjectsInRange(NSRange range);

        // -(NSArray *)keysInRange:(NSRange)range;
        [Export("keysInRange:")]
        // [Verify (StronglyTypedNSArray)]
        NSObject[] KeysInRange(NSRange range);

        //// -(NSUInteger)countByEnumeratingWithState:(NSFastEnumerationState *)state objects:(id *)stackbuf count:(NSUInteger)len;
        //[Export("countByEnumeratingWithState:objects:count:")]
        //unsafe nuint CountByEnumeratingWithState(NSFastEnumerationState* state, out NSObject stackbuf, nuint len);
    }

    // @protocol OOSignatureGenerator <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOSignatureGenerator
    {
        // @required -(NSString *)sign:(NSString *)data;
        [Abstract]
        [Export("sign:")]
        string Sign(string data);
    }

    // @interface OOEmbeddedSecureURLGenerator : NSObject <OOSecureURLGenerator>
    [BaseType(typeof(NSObject))]
    interface OOEmbeddedSecureURLGenerator : OOSecureURLGenerator
    {
        // @property (nonatomic, strong) NSString * apiKey;
        [Export("apiKey", ArgumentSemantic.Strong)]
        string ApiKey { get; set; }

        // @property (nonatomic, strong) id<OOSignatureGenerator> signatureGenerator;
        [Export("signatureGenerator", ArgumentSemantic.Strong)]
        OOSignatureGenerator SignatureGenerator { get; set; }

        // -(id)initWithAPIKey:(NSString *)theAPIKey secret:(NSString *)theSecret;
        [Export("initWithAPIKey:secret:")]
        IntPtr Constructor(string theAPIKey, string theSecret);

        // -(id)initWithAPIKey:(NSString *)theAPIKey signatureGenerator:(id<OOSignatureGenerator>)theSignatureGenerator;
        [Export("initWithAPIKey:signatureGenerator:")]
        IntPtr Constructor(string theAPIKey, OOSignatureGenerator theSignatureGenerator);

        // -(NSURL *)secureURL:(NSString *)host uri:(NSString *)uri params:(NSDictionary *)params;
        //HACK
        // [Export ("secureURL:uri:params:")]
        //NSUrl SecureURL (string host, string uri, NSDictionary @params);
    }

    // @interface OOEmbeddedSignatureGenerator : NSObject <OOSignatureGenerator>
    [BaseType(typeof(NSObject))]
    interface OOEmbeddedSignatureGenerator : OOSignatureGenerator
    {
        // -(id)initWithSecret:(NSString *)theSecret;
        [Export("initWithSecret:")]
        IntPtr Constructor(string theSecret);

        // -(NSString *)sign:(NSString *)data;
        [Export("sign:")]
        string Sign(string data);
    }

    // @interface OOCastModeOptions : NSObject
    [BaseType(typeof(NSObject))]
    interface OOCastModeOptions
    {
        // @property (readonly, nonatomic) NSString * embedCode;
        [Export("embedCode")]
        string EmbedCode { get; }

        // @property (readonly, nonatomic) Float64 playhead;
        [Export("playhead")]
        double Playhead { get; }

        // @property (readonly, nonatomic) BOOL isPlaying;
        [Export("isPlaying")]
        bool IsPlaying { get; }

        // @property (readonly, nonatomic) id<OOEmbedTokenGenerator> embedTokenGenerator;
        [Export("embedTokenGenerator")]
        OOEmbedTokenGenerator EmbedTokenGenerator { get; }

        // @property (readonly, nonatomic) NSString * ccLanguage;
        [Export("ccLanguage")]
        string CcLanguage { get; }

        // @property (readonly, nonatomic) NSString * authToken;
        [Export("authToken")]
        string AuthToken { get; }

        // -(instancetype)initWithEmbedCode:(NSString *)embedCode initialPlayheadTime:(Float64)playhead isPlaying:(BOOL)isPlaying embedTokenGenerator:(id<OOEmbedTokenGenerator>)embedTokenGenerator ccLanguage:(NSString *)ccLanguage authToken:(NSString *)authToken;
        [Export("initWithEmbedCode:initialPlayheadTime:isPlaying:embedTokenGenerator:ccLanguage:authToken:")]
        IntPtr Constructor(string embedCode, double playhead, bool isPlaying, OOEmbedTokenGenerator embedTokenGenerator, string ccLanguage, string authToken);
    }

    // @protocol OOCastManagerProtocol <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOCastManagerProtocol
    {
        // @required -(BOOL)isConnectedToChromecast;
        [Abstract]
        [Export("isConnectedToChromecast")]
        // [Verify (MethodToProperty)]
        bool IsConnectedToChromecast { get; }

        // @required @property (readonly, nonatomic) OOCastPlayer * castPlayer;
        [Abstract]
        [Export("castPlayer")]
        //HACK 
        NSObject CastPlayer { get; }
        //OOCastPlayer CastPlayer { get; }

        // @required -(void)registerWithOoyalaPlayer:(OOOoyalaPlayer *)ooyalaPlayer;
        [Abstract]
        [Export("registerWithOoyalaPlayer:")]
        void RegisterWithOoyalaPlayer(OOOoyalaPlayer ooyalaPlayer);

        // @required @property (readonly, nonatomic) BOOL isInCastMode;
        [Abstract]
        [Export("isInCastMode")]
        bool IsInCastMode { get; }

        // @required @property (readonly, nonatomic) BOOL isMiniControllerInteractionAvailable;
        [Abstract]
        [Export("isMiniControllerInteractionAvailable")]
        bool IsMiniControllerInteractionAvailable { get; }

        // @required @property (nonatomic) float deviceVolume;
        [Abstract]
        [Export("deviceVolume")]
        float DeviceVolume { get; set; }

        // @required -(void)enterCastModeWithOptions:(OOCastModeOptions *)options;
        [Abstract]
        [Export("enterCastModeWithOptions:")]
        void EnterCastModeWithOptions(OOCastModeOptions options);

        // @required -(void)forceAssetRejoin;
        [Abstract]
        [Export("forceAssetRejoin")]
        void ForceAssetRejoin();
    }

    // @interface OOModule : NSObject
    [BaseType(typeof(NSObject))]
    interface OOModule
    {
        // @property (readonly, nonatomic, strong) NSString * name;
        [Export("name", ArgumentSemantic.Strong)]
        string Name { get; }

        // @property (readonly, nonatomic, strong) NSString * type;
        [Export("type", ArgumentSemantic.Strong)]
        string Type { get; }

        // @property (readonly, nonatomic, strong) NSDictionary * metadata;
        [Export("metadata", ArgumentSemantic.Strong)]
        NSDictionary Metadata { get; }

        // -(id)initWithName:(NSString *)name type:(NSString *)type metadata:(NSDictionary *)metadata;
        [Export("initWithName:type:metadata:")]
        IntPtr Constructor(string name, string type, NSDictionary metadata);
    }

    // @protocol OOStreamPlayerMappingCreator <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface OOStreamPlayerMappingCreator
    {
        // @required -(OOStreamPlayer *)newPlayer;
        [Abstract]
        [Export("newPlayer")]
        // [Verify (MethodToProperty)]
        OOStreamPlayer NewPlayer { get; }
    }

    // @protocol OOStreamPlayerMappingPredicate <NSCopying>
    [Protocol, Model]
    interface OOStreamPlayerMappingPredicate : INSCopying
    {
        // @required -(BOOL)matchesStreams:(NSArray *)streams;
        [Abstract]
        [Export("matchesStreams:")]
        // [Verify (StronglyTypedNSArray)]
        bool MatchesStreams(NSObject[] streams);
    }

    // @interface OOManagedAdsPlugin : OOAdSpotPlugin <OOAdSpotPluginDelegate>
    [BaseType(typeof(OOAdSpotPlugin))]
    interface OOManagedAdsPlugin : OOAdSpotPluginDelegate
    {
        // -(instancetype)initWithPlayer:(OOOoyalaPlayer *)p;
        [Export("initWithPlayer:")]
        IntPtr Constructor(OOOoyalaPlayer p);

        // -(void)insertAd:(OOManagedAdSpot *)ad;
        [Export("insertAd:")]
        void InsertAd(OOManagedAdSpot ad);
    }

    // @interface OOStateNotifier : NSObject
    [BaseType(typeof(NSObject))]
    interface OOStateNotifier
    {
        // @property OOOoyalaPlayerState state;
        [Export("state", ArgumentSemantic.Assign)]
        OOOoyalaPlayerState State { get; set; }

        // -(void)notifyPlayheadChange;
        [Export("notifyPlayheadChange")]
        void NotifyPlayheadChange();

        // -(void)notifyAdsLoaded;
        [Export("notifyAdsLoaded")]
        void NotifyAdsLoaded();

        // -(void)notifyAdSkipped;
        [Export("notifyAdSkipped")]
        void NotifyAdSkipped();

        // -(void)notifyAdStarted;
        [Export("notifyAdStarted")]
        void NotifyAdStarted();

        // -(void)notifyAdCompleted;
        [Export("notifyAdCompleted")]
        void NotifyAdCompleted();

        // -(void)notifySSAIAdsMetadataReceived:(OOSsaiAdsMetadata *)adsMetadata;
        //[Export("notifySSAIAdsMetadataReceived:")]
        //void NotifySSAIAdsMetadataReceived(OOSsaiAdsMetadata adsMetadata);

        // -(void)notifySSAIAdPlaying:(OOAdPodInfo *)adPodInfo;
        [Export("notifySSAIAdPlaying:")]
        void NotifySSAIAdPlaying(OOAdPodInfo adPodInfo);

        // -(void)notifySSAIAdPlayed;
        [Export("notifySSAIAdPlayed")]
        void NotifySSAIAdPlayed();
    }

    // @interface OOAssetLoaderDelegate : NSObject <AVAssetResourceLoaderDelegate>
    [BaseType(typeof(NSObject))]
    [DisableDefaultCtor]
    interface OOAssetLoaderDelegate : IAVAssetResourceLoaderDelegate
    {
        // -(instancetype)initWithAsset:(AVURLAsset *)asset pcode:(NSString *)pcode authToken:(NSString *)authToken secureURLGenerator:(id<OOSecureURLGenerator>)secureURLGenerator timeout:(NSTimeInterval)timeout __attribute__((objc_designated_initializer));
        [Export("initWithAsset:pcode:authToken:secureURLGenerator:timeout:")]
        [DesignatedInitializer]
        IntPtr Constructor(AVUrlAsset asset, string pcode, string authToken, OOSecureURLGenerator secureURLGenerator, double timeout);

        // -(instancetype)initWithAsset:(AVURLAsset *)asset stream:(OOStream *)stream pcode:(NSString *)pcode authToken:(NSString *)authToken timeout:(NSTimeInterval)timeout;
        [Export("initWithAsset:stream:pcode:authToken:timeout:")]
        IntPtr Constructor(AVUrlAsset asset, OOStream stream, string pcode, string authToken, double timeout);

        //[Wrap("WeakDelegate")]
        //OOFairplayContentKeyDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<OOFairplayContentKeyDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) NSURL * fairplayKeyURL;
        [Export("fairplayKeyURL", ArgumentSemantic.Assign)]
        NSUrl FairplayKeyURL { get; set; }
    }

    // @interface OOControlsViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    [Protocol]
    interface OOControlsViewController
    {
        [Wrap("WeakDelegate")]
        NSObject Delegate { get; set; }

        // @property (nonatomic, weak) id delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, weak) OOOoyalaPlayer * player;
        [Export("player", ArgumentSemantic.Weak)]
        OOOoyalaPlayer Player { get; set; }

        // @property (nonatomic, weak) UIView * overlay;
        [Export("overlay", ArgumentSemantic.Weak)]
        UIView Overlay { get; set; }

        // @property (nonatomic) UIActivityIndicatorView * activityView;
        [Export("activityView", ArgumentSemantic.Assign)]
        UIActivityIndicatorView ActivityView { get; set; }

        // @property (nonatomic) UIView * controls;
        [Export("controls", ArgumentSemantic.Assign)]
        UIView Controls { get; set; }

        // @property (nonatomic) BOOL isVisible;
        [Export("isVisible")]
        bool IsVisible { get; set; }

        // @property (nonatomic) NSTimer * hideControlsTimer;
        [Export("hideControlsTimer", ArgumentSemantic.Assign)]
        NSTimer HideControlsTimer { get; set; }

        // @property (nonatomic) BOOL autohideControls;
        [Export("autohideControls")]
        bool AutohideControls { get; set; }

        // -(instancetype)initWithControlsType:(OOOoyalaPlayerControlType)controlsType player:(OOOoyalaPlayer *)player overlay:(UIView *)overlay delegate:(id)theDelegate;
        [Export("initWithControlsType:player:overlay:delegate:")]
        IntPtr Constructor(OOOoyalaPlayerControlType controlsType, OOOoyalaPlayer player, UIView overlay, NSObject theDelegate);

        // -(void)showControls;
        [Export("showControls")]
        void ShowControls();

        // -(void)hideControls;
        [Export("hideControls")]
        void HideControls();

        // -(void)syncUIWithState:(OOOoyalaPlayerState)state;
        [Export("syncUIWithState:")]
        void SyncUIWithState(OOOoyalaPlayerState state);

        // -(void)setFullScreenButtonShowing:(BOOL)isShowing;
        [Export("setFullScreenButtonShowing:")]
        void SetFullScreenButtonShowing(bool isShowing);

        // -(void)setVolumeButtonShowing:(BOOL)isShowing;
        [Export("setVolumeButtonShowing:")]
        void SetVolumeButtonShowing(bool isShowing);

        // -(OOUIProgressSliderMode)sliderMode;
        [Export("sliderMode")]
        //[Verify(MethodToProperty)]
        OOUIProgressSliderMode SliderMode { get; }

        // -(void)changeButtonLanguage:(NSString *)language;
        [Export("changeButtonLanguage:")]
        void ChangeButtonLanguage(string language);

        // -(void)switchVideoGravity;
        [Export("switchVideoGravity")]
        void SwitchVideoGravity();

        // -(void)updateClosedCaptionsPosition;
        [Export("updateClosedCaptionsPosition")]
        void UpdateClosedCaptionsPosition();

        // -(void)updateClosedCaptionsButton;
        [Export("updateClosedCaptionsButton")]
        void UpdateClosedCaptionsButton();

        // -(void)toggleControls;
        [Export("toggleControls")]
        void ToggleControls();
    }

    //[Static]
    // [Verify (ConstantsInterfaceAssociation)]
    partial interface Constants
    {
        // // extern NSString *const OO_DELIVERY_TYPE_HLS;
        // [Field ("OO_DELIVERY_TYPE_HLS")]
        // NSString OO_DELIVERY_TYPE_HLS { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_AUDIO_HLS;
        // [Field ("OO_DELIVERY_TYPE_AUDIO_HLS")]
        // NSString OO_DELIVERY_TYPE_AUDIO_HLS { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_AUDIO_M4A;
        // [Field ("OO_DELIVERY_TYPE_AUDIO_M4A")]
        // NSString OO_DELIVERY_TYPE_AUDIO_M4A { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_AUDIO_OGG;
        // [Field ("OO_DELIVERY_TYPE_AUDIO_OGG")]
        // NSString OO_DELIVERY_TYPE_AUDIO_OGG { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_MP4;
        // [Field ("OO_DELIVERY_TYPE_MP4")]
        // NSString OO_DELIVERY_TYPE_MP4 { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_REMOTE_ASSET;
        // [Field ("OO_DELIVERY_TYPE_REMOTE_ASSET")]
        // NSString OO_DELIVERY_TYPE_REMOTE_ASSET { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_SMOOTH;
        // [Field ("OO_DELIVERY_TYPE_SMOOTH")]
        // NSString OO_DELIVERY_TYPE_SMOOTH { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_AKAMAI_HD2_VOD_HLS;
        // [Field ("OO_DELIVERY_TYPE_AKAMAI_HD2_VOD_HLS")]
        // NSString OO_DELIVERY_TYPE_AKAMAI_HD2_VOD_HLS { get; }

        // // extern NSString *const OO_DELIVERY_TYPE_AKAMAI_HD2_HLS;
        // [Field ("OO_DELIVERY_TYPE_AKAMAI_HD2_HLS")]
        // NSString OO_DELIVERY_TYPE_AKAMAI_HD2_HLS { get; }
    }

    // @interface OOOoyalaTVPlayerViewController : UIViewController
    [BaseType(typeof(UIViewController))]
    interface OOOoyalaTVPlayerViewController
    {
        // @property (nonatomic) OOOoyalaPlayer * player;
        [Export("player", ArgumentSemantic.Assign)]
        OOOoyalaPlayer Player { get; set; }

        // @property (nonatomic) BOOL playbackControlsEnabled;
        [Export("playbackControlsEnabled")]
        bool PlaybackControlsEnabled { get; set; }

        // @property (nonatomic) UIColor * progressTintColor;
        [Export("progressTintColor", ArgumentSemantic.Assign)]
        UIColor ProgressTintColor { get; set; }

        // -(instancetype)initWithPlayer:(OOOoyalaPlayer *)player;
        [Export("initWithPlayer:")]
        IntPtr Constructor(OOOoyalaPlayer player);

        // -(void)showProgressBar;
        [Export("showProgressBar")]
        void ShowProgressBar();

        // -(void)hideProgressBar;
        [Export("hideProgressBar")]
        void HideProgressBar();

        // -(NSArray *)availableOptions;
        [Export("availableOptions")]
        //[Verify(MethodToProperty), Verify(StronglyTypedNSArray)]
        NSObject[] AvailableOptions { get; }

        // -(BOOL)closedCaptionMenuDisplayed;
        [Export("closedCaptionMenuDisplayed")]
        //[Verify(MethodToProperty)]
        bool ClosedCaptionMenuDisplayed { get; }

        // -(void)setupClosedCaptionsMenu;
        [Export("setupClosedCaptionsMenu")]
        void SetupClosedCaptionsMenu();

        // -(void)addClosedCaptionsView;
        [Export("addClosedCaptionsView")]
        void AddClosedCaptionsView();

        // -(void)removeClosedCaptionsMenu;
        [Export("removeClosedCaptionsMenu")]
        void RemoveClosedCaptionsMenu();

        // -(void)updatePlayheadWithSeekTime:(double)seekTime;
        [Export("updatePlayheadWithSeekTime:")]
        void UpdatePlayheadWithSeekTime(double seekTime);
    }
}
