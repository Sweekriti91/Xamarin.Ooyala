#!/bin/sh
xcodebuild -project ${PROJECT_NAME}.xcodeproj -sdk appletvsimulator -target OoyalaTVSkinSDK -configuration ${CONFIGURATION} BUILD_DIR=${BUILD_DIR} OBJROOT="${OBJROOT}/DependentBuilds/OoyalaTVSkinSDKUniversal/"
xcodebuild -project ${PROJECT_NAME}.xcodeproj -sdk appletvos -target OoyalaTVSkinSDK -configuration ${CONFIGURATION} BUILD_DIR=${BUILD_DIR} OBJROOT="${OBJROOT}/DependentBuilds/OoyalaTVSkinSDKUniversal/"

